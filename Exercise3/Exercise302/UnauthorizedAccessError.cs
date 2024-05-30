namespace Exercise3.Exercise302
{
    internal class UnauthorizedAccessError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to access information without proper authorization. This fired an error!";
        }
    }
}
