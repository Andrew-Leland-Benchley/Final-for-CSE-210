namespace Matt_Manleys_Plumbing_Extravaganza.Game.Scripting
{
    
    /// <summary>
    /// A thing that is done in the game.
    /// </summary>
    public abstract class Action
    {

        private bool _enabled = true;


        public Action() { }


        public abstract void Execute(Scene scene, float deltaTime, IActionCallback callback);
    

        public bool IsEnabled()
        {
            return _enabled;
        }

    }
}