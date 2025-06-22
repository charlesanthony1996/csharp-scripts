// Explain the process of serialization and deserialization. What is the difference
// between using Serialization and File Streams?


// What is Serialization?
// Serialization is the process of converting an object into a format that can be stored or transmitted, such as:

// A file (e.g., .bin, .json, .xml)

// A stream (e.g., network stream)



// This is commonly used to:

// Save object state to a file or memory

// Send objects over a network (e.g., web APIs)



// In C#, serialization can be done using:

// System.Text.Json.JsonSerializer (for JSON)

// System.Xml.Serialization.XmlSerializer (for XML)

// System.Runtime.Serialization.Formatters.Binary.BinaryFormatter (⚠️ Obsolete for security reasons)




// What is Deserialization?
// Deserialization is the reverse process: converting a serialized data format back into an object in memory.


using System.Text.Json;

public class Person {
    public string Name { get; set; }
    public int Age { get; set; }
}

// Serialize
Person p = new Person { Name = "Alice", Age = 30 };
string json = JsonSerializer.Serialize(p); // {"Name":"Alice","Age":30}

// Deserialize
Person p2 = JsonSerializer.Deserialize<Person>(json);


// What are File Streams?
// File Streams provide low-level byte access to files. They’re used to read/write bytes to/from files.

// C# uses FileStream in System.IO for this:

using System.IO;

FileStream stream = new FileStream("data.txt", FileMode.Create);


// Difference Between Serialization and File Streams

// | Feature            | **Serialization**                                  | **File Streams**                                   |
// | ------------------ | -------------------------------------------------- | -------------------------------------------------- |
// | **Purpose**        | Convert objects to a storable/transmittable format | Read/write raw bytes to files                      |
// | **Level**          | High-level (object-focused)                        | Low-level (byte-focused)                           |
// | **Use Case**       | Persist object state, send over network            | General-purpose file I/O                           |
// | **Ease of Use**    | Easier for objects                                 | Requires manual handling of format                 |
// | **Data Format**    | JSON, XML, Binary, etc.                            | Any raw data (bytes, strings, etc.)                |
// | **Common Classes** | `JsonSerializer`, `XmlSerializer`, etc.            | `FileStream`, `StreamReader`, `BinaryWriter`, etc. |


// Summary:
// Serialization is best when working with objects that need to be stored or transferred.

// File Streams are lower-level tools for handling file input/output.

// You can combine both: e.g., serialize an object to JSON and write it to a file using a FileStream.

