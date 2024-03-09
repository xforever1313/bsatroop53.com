﻿//
// BSATroop53 Website DevOps - Build Tools.
// Copyright (C) 2024 Seth Hendrick
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.
//

using Cake.Common.IO;
using Cake.Frosting;

namespace DevOps.Tasks
{
    [TaskName( "generate" )]
    [TaskDescription( "Builds the site for publishing." )]
    public sealed class GenerateTask : FrostingTask<BuildContext>
    {
        public override void Run( BuildContext context )
        {
            context.EnsureDirectoryExists( context.SiteOutput );
            context.CleanDirectory( context.SiteOutput );
            context.RunPretzel( "bake", true );
        }
    }
}
