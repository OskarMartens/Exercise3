namespace Exercise3.Exercise302
{
    internal class AuthenticationError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to access content without proper authentication. This fired an error!";
        }
    }
}
