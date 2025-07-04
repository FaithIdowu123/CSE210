using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string RandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count() + 1);
        string prompt = $"{_prompts[number]} ";
        return prompt;
    }
}