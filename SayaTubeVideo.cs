namespace tpmodul5_1302204035;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    
    public SayaTubeVideo(string title, int playCount)
    {
        //exception try catch
        try
        {
            if (title.Length == 0)
            {
                throw new System.ArgumentException("Title tidak boleh kosong");
            }
            
            if (title.Length > 100)
            {
                throw new System.ArgumentException("Title tidak boleh lebih dari 100 karakter");
            }
        }
        catch (System.ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        this.id = new System.Random().Next(999);
        this.title = title;
        this.playCount = playCount;
    }
    
    public void IncreasePlayCount(int count)
    {
        //exception try catch
        try
        {
            if (count > 10000000)
            {
                throw new System.ArgumentException("Play count tidak boleh lebih dari 10.000.000");
            }
        }
        catch (System.ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
        Console.WriteLine("==========================");
    }
}