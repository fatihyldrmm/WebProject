namespace WebClient.Models.EntityFeed
{
    public static class PatientGenderFeed
    {
        public static List<string> Gender()
        {
            List<string> gender = new List<string> {
                                "MALE",
                                "FEMALE"
                            };
            return gender;
        }
    }
}
