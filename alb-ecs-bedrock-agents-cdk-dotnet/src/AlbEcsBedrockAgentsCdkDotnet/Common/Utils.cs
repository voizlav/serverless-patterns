using System;
using System.Linq;
using Amazon.CDK;

namespace AlbEcsBedrockAgentsCdkDotnet.Common;

internal static class Utils
{
    /// <summary>
    /// Generates a random string from the stack id
    /// </summary>
    /// <returns></returns>
    internal static string GenerateRandomStringFromStackId(string stackId)
    {
        return Fn.Select(4, Fn.Split("-", Fn.Select(2, Fn.Split("/", stackId))));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="region"></param>
    /// <returns></returns>
    internal static string GetTitanV2FMArn(string region)
    {
        return $"arn:aws:bedrock:{region}::" + "foundation-model/" + Constants.Bedrock_FoundationModel_Titan_Embed_Text_V2;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="region"></param>
    /// <returns></returns>
    internal static string GetCluade3HaikuFMArn(string region)
    {
        return $"arn:aws:bedrock:{region}::" + "foundation-model/" + Constants.Bedrock_FoundationModel_Claude3_5_Haiku;
    }    
}