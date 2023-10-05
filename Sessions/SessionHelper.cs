using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ServicioSocial.Sessions
{
    public static class SessionHelper
    {

        public static void SetObjectAsJson(this ISession session, string clave, object valor)
        {
            session.SetString(clave, JsonConvert.SerializeObject(valor));
        }

        public static T GetObjectFromJson<T>(this ISession session, string clave)
        {
            var value = session.GetString(clave);
            if (value == null)
            {
                return default(T);
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
        }

    }
}