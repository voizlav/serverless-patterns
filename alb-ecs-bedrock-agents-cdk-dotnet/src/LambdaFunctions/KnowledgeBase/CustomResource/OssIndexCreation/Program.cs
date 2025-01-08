using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.SystemTextJson;
using OssIndexCreation.Serialization;

namespace OssIndexCreation;

public class Program
{
    /// <summary>
    /// The main entry point for the Lambda function. The main function is called once during the Lambda init phase. It
    /// initializes the .NET Lambda runtime client passing in the function handler to invoke for each Lambda event and
    /// the JSON serializer to use for converting Lambda JSON format to the .NET types. 
    /// </summary>
    private static async Task Main()
    {
        Func<object, ILambdaContext, Task> handler = Function.FunctionHandler;
        await LambdaBootstrapBuilder.Create(handler, new SourceGeneratorLambdaJsonSerializer<LambdaFunctionJsonSerializerContext>())
            .Build()
            .RunAsync();
    }
}