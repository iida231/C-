# C#のデザインパターン

- Dto

```cs

public class sampleDto
{
  
    public string _Samplefield = string.Empty;

      [JsonPropertyName("propertyname")]

      public string SampleField
      {
          get=>_SamplepleField
          set
          {
              if(string.IsNullOrWhiteSpace(Value))
              {
                  throw new ArgumentException("SampleField is not specified")
              }
              _SampleField = value;
          }
      }
      public SampleDto(){}

      public SamlpleDto(string sampleField)
      {
          SampleField = sampleField;
      }
}

```