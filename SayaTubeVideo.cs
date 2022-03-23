namespace tpmodul5_1302204035;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    
    public SayaTubeVideo(string title, int playCount)
    {
        //random id
        this.id = new System.Random().Next(999);
        this.title = title;
        this.playCount = playCount;
    }
    
    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Title : " + title);
        Console.WriteLine("Play Count : " + playCount);
    }
}