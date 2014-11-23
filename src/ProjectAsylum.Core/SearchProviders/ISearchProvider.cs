namespace ProjectAsylum.Core.SearchProviders
{
    public interface ISearchProvider
    {
        bool RssSupport { get; set; } 
        bool SearchSupport { get; set; }
        ProviderType ProviderType { get; set; }
    }
}