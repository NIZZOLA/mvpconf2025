// Original object
var person = new Person {
  FirstName = "John",
  LastName = "Doe",
  Email = "johndoe@gmail.com",
  PhoneNumbers = [new() {Number = "123-456-7890", Type = PhoneNumberType.Mobile}],
  Address = new Address
  {
    Street = "123 Main St",
    City = "Anytown",
    State = "TX"
  }
};

// Raw JSON Patch document
var jsonPatch = """
[
  { "op": "replace", "path": "/FirstName", "value": "Jane" },
  { "op": "remove", "path": "/Email"},
  { "op": "add", "path": "/Address/ZipCode", "value": "90210" },
  {
    "op": "add",
    "path": "/PhoneNumbers/-",
    "value": { "Number": "987-654-3210", "Type": "Work" }
  }
]
""";

// Deserialize the JSON Patch document
var patchDoc = JsonSerializer.Deserialize<JsonPatchDocument<Person>>(jsonPatch);

// Apply the JSON Patch document
patchDoc!.ApplyTo(person);

// Output updated object
Console.WriteLine(JsonSerializer.Serialize(person, serializerOptions));