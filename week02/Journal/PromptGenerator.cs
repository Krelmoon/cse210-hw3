using System;
using System.Collections.Generic;
public class PromptGenerator
{   
    public List<string> _prompts = new List<string>();
    public Random random = new Random{};
    public HashSet<int> _assignedIndex = new HashSet<int>();
        

        public string GetRandomPrompt()
        {   
            _prompts.Add("Who was the most interesting person I interacted with today?");
            _prompts.Add("What was the best part of my day?");
            _prompts.Add("How did I see the hand of the Lord in my life today?");
            _prompts.Add("What was the strongest emotion I felt today?");
            _prompts.Add("If I had one thing I could do over today, what would it be?");

            // to insure that prompts are not assigned more than once each session
            int _promptsLen = _prompts.Count;
            int _promptsIndex;

            do
            {
                _promptsIndex = random.Next(_promptsLen);
            } while (_assignedIndex.Contains(_promptsIndex));
            // loop that keeps going as long as _promptsIndex is in _assignedIndex
            
            // send the unassigned _promptsIndex to the hashset
            _assignedIndex.Add(_promptsIndex);
    
            return _prompts[_promptsIndex];
        }
}