namespace Exercise3.Exercise302
{
    public class App
    {
        public void Run()
        {
            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new NumericInputError());
            errors.Add(new AuthenticationError());
            errors.Add(new UnauthorizedAccessError());
            errors.Add(new UnavailableContentError());

            foreach (var error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
