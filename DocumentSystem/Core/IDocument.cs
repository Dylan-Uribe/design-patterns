namespace DocumentSystem.Core;

public interface IDocument
{
    string Title { get; set; }
    void Show();
    IDocument Clone();
}