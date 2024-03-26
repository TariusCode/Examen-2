using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

public partial class EncuestaForm : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            Random rnd = new Random();
            NumeroEncuesta.Text = "Número de Encuesta: " + rnd.Next(1000, 9999);
        }
    }

    protected void btnEnviarEncuesta_Click(object sender, EventArgs e)
    {
        
        string nombre = Nombre.Text;
        string apellido = Apellido.Text;
        DateTime fechaNacimiento = DateTime.Parse(FechaNacimiento.Text);
        string correoElectronico = CorreoElectronico.Text;
        bool carroPropio = CarroPropio.Text.ToLower() == "si";

        // Validar edad
        int edad = DateTime.Now.Year - fechaNacimiento.Year;
        if (edad < 18 || edad > 50)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('La edad debe estar entre 18 y 50 años')", true);
            return;
        }

        // Guardar la encuesta en la base de datos
        string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        string query = "INSERT INTO Encuestas (Nombre, Apellido, FechaNacimiento, CorreoElectronico, CarroPropio) " +
                       "VALUES (@Nombre, @Apellido, @FechaNacimiento, @CorreoElectronico, @CarroPropio)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Apellido", apellido);
            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
            command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
            command.Parameters.AddWithValue("@CarroPropio", carroPropio);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Encuesta enviada correctamente')", true);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al enviar la encuesta')", true);
            }
        }
    }
}
