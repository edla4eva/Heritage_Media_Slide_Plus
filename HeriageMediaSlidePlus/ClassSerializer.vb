Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO

Public Class ClassSerializer
    ' '' /// <summary>
    ' ''/// Serializes an object.
    ' ''/// </summary>
    ' ''/// <typeparam name="T"></typeparam>
    ' ''/// <param name="serializableObject"></param>
    ' ''/// <param name="fileName"></param>



    Public Shared Function SerializeObject(Of T)(serializableObject As T, fileName As String)

        If (serializableObject Is Nothing) Then Return 0

        Try

            Dim xmlDocument As XmlDocument = New XmlDocument()
            Dim serializer As XmlSerializer = New XmlSerializer(serializableObject.GetType())
            Using stream As MemoryStream = New MemoryStream()

                serializer.Serialize(stream, serializableObject)
                stream.Position = 0
                xmlDocument.Load(stream)
                xmlDocument.Save(fileName)
            End Using

        Catch ex As Exception

            ''Log exception here
        End Try



        ' ''/// <summary>
        ' ''/// Deserializes an xml file into an object list
        ' ''/// </summary>
        ' ''/// <typeparam name="T"></typeparam>
        ' ''/// <param name="fileName"></param>
        ' ''/// <returns></returns>
    End Function
    Public Shared Function DeSerializeObject(Of T)(fileName As String) As T

        If (String.IsNullOrEmpty(fileName)) Then Return Nothing ' default(T)

        Dim objectOut As T = Nothing ' default(T) C#

        Try

            Dim xmlDocument As XmlDocument = New XmlDocument()
            xmlDocument.Load(fileName)
            Dim xmlString As String = xmlDocument.OuterXml

            Using read As StringReader = New StringReader(xmlString)

                Dim outType As Type = GetType(T) ' =  typeof(T)  C#

                Dim serializer As XmlSerializer = New XmlSerializer(outType)
                Using reader As XmlReader = New XmlTextReader(read)

                    objectOut = CType(serializer.Deserialize(reader), T)
                End Using
            End Using

        Catch ex As Exception

            ''Log exception here
        End Try

        Return objectOut
    End Function

End Class
