
using OpenAI;
using OpenAI.Chat;



//Console.WriteLine("Hello, World!");

const string OpenAIAPIKey = "";

OpenAIClient client = new OpenAIClient(OpenAIAPIKey);

//Reasoning : gpt-5-nano - Slow and accurate, step-by-step reasoning
//Non-Reasoning : gpt-4.1-nano - Fast and accurate
var agent =  client.GetChatClient("gpt-4.1-nano").AsAIAgent();

var response = await agent.RunAsync("What is the capital of France?");

Console.WriteLine(response);
