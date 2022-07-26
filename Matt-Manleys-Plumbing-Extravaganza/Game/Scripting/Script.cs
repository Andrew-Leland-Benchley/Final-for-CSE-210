using System.Collections.Generic;
using Matt_Manleys_Plumbing_Extravaganza.Game.Casting;


namespace Matt_Manleys_Plumbing_Extravaganza.Game.Scripting
{

    /// <summary>
    /// A collection of Actions.
    /// </summary>
    public class Script
    {

        private Dictionary<int, List<Action>> _current 
            = new Dictionary<int, List<Action>>();


        private Dictionary<int, List<Action>> _removed
            = new Dictionary<int, List<Action>>();


        public Script() { }


        public void Add(int phase, Action action)
        {
            Validator.CheckInRange(phase, Phase.Input, Phase.Output);
            Validator.CheckNotNull(action);
            
            if (!_current.ContainsKey(phase))
            {
                _current[phase] = new List<Action>();
            }

            if (!_current[phase].Contains(action))
            {
                _current[phase].Add(action);
            }
        }


        public void ApplyChanges()
        {
            foreach (int phase in _removed.Keys)
            {
                foreach(Action action in _removed[phase])
                {
                    if (_current[phase].Contains(action))
                    {
                        _current[phase].Remove(action);
                    }
                }
            }
            _removed.Clear();
        }


        public void Clear()
        {
            _current.Clear();
            _removed.Clear();
        }


        public List<Action> GetAllActionsIn(int phase)
        {
            Validator.CheckInRange(phase, Phase.Input, Phase.Output);
            List<Action> results = new List<Action>();
            if (_current.ContainsKey(phase))
            {
                results = _current[phase];
            }
            return results;
        }
        
    }
}