public static Object ObjectToXML(string xml, Type objectType)
{
    StringReader strReader = null;
    XmlSerializer serializer = null;
    XmlTextReader xmlReader = null;
    Object obj = null;
    try
    {
        strReader = new StringReader(xml);
        serializer = new XmlSerializer(objectType);
        xmlReader = new XmlTextReader(strReader);
        obj = serializer.Deserialize(xmlReader);
    }
    catch (Exception exp)
    {
        //Handle Exception Code
    }
    finally
    {
        if (xmlReader != null)
        {
            xmlReader.Close();
        }
        if (strReader != null)
        {
            strReader.Close();
        }
    }
    return obj;
}

