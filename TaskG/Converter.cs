using System;

internal class Converter : IConverter<MessageNetwork, MessageDb>
{
    public MessageDb Convert(MessageNetwork obj)
    {
        long id = obj.Id;
        string content = obj.Content.Replace(" ", "");
        string url = obj.ImageNetwork.Url.Replace(" ", "");

        return new MessageDb(id, content, url);
    }

  

}