using Microsoft.Extensions.AI;
using OllamaSharp.Models;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace OllamaSharp;
#pragma warning restore IDE0130 // Namespace does not match folder structure

/// <summary>
/// Extension methods to stream IAsyncEnumerable to its end and return one single result value
/// </summary>
public static class ChatOptionsExtensions
{
	/// <summary>
	/// Adds Ollama specific options to the additional properties of ChatOptions.
	/// These can be interpreted sent to the Ollama API by OllamaSharp.
	/// </summary>
	/// <param name="chatOptions">The chat options to set Ollama options on</param>
	/// <param name="option">The Ollama option to set, like OllamaOption.NumCtx for the option 'num_ctx'</param>
	/// <param name="value">The value for the option</param>
	public static ChatOptions AddOllamaOption(this ChatOptions chatOptions, OllamaOption option, object value)
	{
		chatOptions.AdditionalProperties ??= [];
		chatOptions.AdditionalProperties[option.Name] = value;
		return chatOptions;
	}
}