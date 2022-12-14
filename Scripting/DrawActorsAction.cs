using System.Collections.Generic;
using PucMan.Game.Casting;
using PucMan.Game.Services;


namespace PucMan.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of DrawActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            List<Actor> allactors = cast.GetAllActors();
            
            videoService.ClearBuffer();
            videoService.DrawActors(allactors);
            videoService.FlushBuffer();
        }
    }
}