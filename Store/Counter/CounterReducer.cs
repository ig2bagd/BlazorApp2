using Fluxor;

namespace BlazorApp2.Store.Counter
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnIncreaseCounter(CounterState state, IncreaseCounter action) => state with
        {
            // TypeScript => {...state, Count: state.Count + action.Step}
            Count = state.Count + action.Step
        };
    }
}
