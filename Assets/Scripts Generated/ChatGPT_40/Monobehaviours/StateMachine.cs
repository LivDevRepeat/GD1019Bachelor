namespace Scripts_Generated.ChatGPT_40.Monobehaviours
{
    using System;
    using System.Collections.Generic;

    public class StateMachine<TState, TTrigger>
    {
        private readonly Dictionary<TState, Dictionary<TTrigger, TState>> _transitions = new Dictionary<TState, Dictionary<TTrigger, TState>>();
        private TState _currentState;

        public StateMachine(TState initialState)
        {
            _currentState = initialState;
        }

        public TState CurrentState => _currentState;

        public void AddTransition(TState fromState, TTrigger trigger, TState toState)
        {
            if (!_transitions.ContainsKey(fromState))
                _transitions[fromState] = new Dictionary<TTrigger, TState>();

            _transitions[fromState][trigger] = toState;
        }

        public bool Fire(TTrigger trigger)
        {
            if (_transitions.ContainsKey(_currentState) && _transitions[_currentState].ContainsKey(trigger))
            {
                _currentState = _transitions[_currentState][trigger];
                return true;
            }
            return false; // Transition not possible
        }
    }

}