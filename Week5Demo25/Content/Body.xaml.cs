namespace Week5Demo25.Content;
using Week5Demo25.Controls;

public partial class Body : ContentView
{
	public Body()
	{
		InitializeComponent();
	}

    private void OnFormSubmit(object sender, FormSubmitEventArgs e)
    {
        // Display a user-friendly alert with the form data
        string message = $"Name: {e.Name}\nEmail: {e.Email}\nParticipants: {e.Participants}";
        App.Current.Windows[0].Page.DisplayAlert("Form Data", message, "OK");
    }
}