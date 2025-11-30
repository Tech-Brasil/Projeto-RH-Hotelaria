using System.Configuration;
using System.Data.SqlClient;

namespace Projeto_RH_HOTELARIA.Data
{
    public static class Db
    {
        public static SqlConnection Connect() =>
                new SqlConnection(ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString);
    }
}
