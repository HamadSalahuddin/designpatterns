namespace InterfaceSegregationPrinciple
{
    public interface IMdTextProcessor: ITextProcessor
    {
        string ConvertMdText(string inputText);
    }
}
