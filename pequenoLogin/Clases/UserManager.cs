class UserManager {
    //lista de usuarios
    private List<User> listaUsuarios = new List<User>();
    //Metodos
    public void registrarUsuario() { //Metodo para registrar a los usuarios
        Console.WriteLine("Ingrese el username: ");
        string usuario = Console.ReadLine();
        Console.WriteLine("Ingrese la contraseña: ");
        string contra = Console.ReadLine();
        agregarUsuario(usuario, contra);
    }

    public void agregarUsuario(string username, string password) {
        if (listaUsuarios.Count == 0) { //Verificamos si la lista ya tiene usuarios, sino, colocamos el primero
            User user0 = new User(username, password);
            listaUsuarios.Add(user0);
            return;
        }
        else {
            //Recorremos la lista para verificar si el usuario existe antes de agregarlo, si ya existe entonces salimos del metodo con el return
            for (int i = 0; i < listaUsuarios.Count; i++) {
                if (listaUsuarios[i].Username == username) {
                    Console.WriteLine("Este usuario ya existe");
                return;
                }
            }
        }
        //Si el usuario no existe entonces lo agregamos
        User user = new User(username, password);
        listaUsuarios.Add(user);
    }

    public void mostrarUsuarios() {
        if (listaUsuarios.Count == 0) {
            Console.WriteLine("No hay usuarios registrados");
        }
        else {
            Console.WriteLine("Lista de usuarios\n");
            for (int i = 0; i < listaUsuarios.Count; i++) {
                Console.WriteLine($"{i}: {listaUsuarios[i].Username}");
            }
        }
    }

    public void inicarSesion() {
        int maxIntentos = 3, cantIntentos = 0;
        bool encontrado = false;
        while (!encontrado && cantIntentos < maxIntentos) {
            Console.WriteLine("Ingrese el username: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña: ");
            string contra = Console.ReadLine();

            /*Verificamos que el usuario existe, si es asi salimos del metodo con el return a modo de simular de que el usuario ya hizo lo que tenia
            que hacer*/
            for (int i = 0; i < listaUsuarios.Count; i ++) {
                if (listaUsuarios[i].Username == usuario && listaUsuarios[i].Password == contra) {
                    Console.WriteLine($"Inicio de sesion realizado, hola {listaUsuarios[i].Username}");
                    encontrado = true;
                    return;
                }
            }
            cantIntentos++;
            Console.WriteLine($"Inicio de sesion fallido, te quedan: {maxIntentos - cantIntentos}\n");
        }
    }
}