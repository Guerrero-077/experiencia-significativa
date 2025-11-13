using System.ComponentModel;

namespace Entity.Enums
{
    /// <summary>
    /// Represents the type of documents for people
    /// </summary>
    public enum DocumentType
    {
        [Description("Cédula de ciudadanía")]
        CitizenshipId = 1,

        [Description("Tarjeta de identidad")]
        MinorIdCard = 2,

        [Description("Cédula de extranjería")]
        ForeignerId = 3,

        [Description("Pasaporte")]
        Passport = 4,

    }

}