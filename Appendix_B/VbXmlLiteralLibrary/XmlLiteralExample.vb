Public Class XmlLiteralExample
    Public Sub MakeXmlFileUsingLiterals()
        ' Notice that we can inline XML data
        ' to an XElement. 
        Dim doc As XElement =
            <Inventory>
                <Car ID="1000">
                    <PetName>Jimbo</PetName>
                    <Color>Red</Color>
                    <Make>Ford</Make>
                </Car>
                <Car>
                    <Make>Yugo</Make>
                </Car>
            </Inventory>

        doc.Save("InventoryVBStyle.xml")
    End Sub
End Class
