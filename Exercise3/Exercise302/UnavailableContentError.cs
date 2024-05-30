namespace Exercise3.Exercise302
{
    internal class UnavailableContentError : UserError
    {
        public override string UEMessage()
        {
            return "No content could be found with the information you passed. This fired an error!";
        }
    }
}
