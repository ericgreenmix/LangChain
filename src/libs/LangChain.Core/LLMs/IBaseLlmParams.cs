using LangChain.Base;
using LangChain.Cache;

namespace LangChain.LLMS;

public interface IBaseLlmParams : IBaseLanguageModelParams
{
    internal decimal? Concurrency { get; set; }
    
    internal BaseCache? Cache { get; set; }
}