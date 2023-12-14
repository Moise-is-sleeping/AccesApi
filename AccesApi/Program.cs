
using System.Net;
using System.Text;

String[] ReadWebsite()
{
    string webURL = "https://rickandmortyapi.com/api/character";
    WebClient wc = new WebClient();
    wc.Headers.Add("user-agent", "Only a Header!");
    byte[] rawByteArray = wc.DownloadData(webURL);
    string webContent = Encoding.UTF8.GetString(rawByteArray);
    return webContent.Split("id");
}

String[] ReadLine(string line)
{
    String[] episodes = line.Split(",");
    return episodes;
}

string[] websiteList = ReadWebsite();


void GetInfo(String Nombre)
{
    foreach(string line in websiteList){
        if (line.Contains(Nombre))
        {
            foreach (string ep in ReadLine(line))
            {
                if (ep.Contains(Nombre) || ep.Contains("species") || ep.Contains("gender"))
                {
                    Console.WriteLine(ep);
                }
                if (ep.Contains("https://rickandmortyapi.com/api/episode"))
                {
                    Console.WriteLine(ep);
                }
            
            }
        }

    }
}

Console.WriteLine("Nombre a buscar : ");
GetInfo(Console.ReadLine());

