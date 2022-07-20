using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis;

namespace MyGenerator
{
	[Generator]
	public class DebuggerAttachToSourceGenerator : ISourceGenerator
	{
		public void Execute(GeneratorExecutionContext context)
		{
		}

		public void Initialize(GeneratorInitializationContext context)
		{
			Console.Error.WriteLine($"Debug Source Generator Initializing... Attach to PID: {Process.GetCurrentProcess().Id}");
			while (!Debugger.IsAttached)
			{
				Thread.Sleep(100);
			}
			Debugger.Break();
		}
	}
}
