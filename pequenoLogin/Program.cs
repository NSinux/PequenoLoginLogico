class Program {
    static void Main() {
        //Varaibles
        bool salir = false;
        int opc;
        //Objetos
        Menu menu = new Menu();
        UserManager user = new UserManager();
        //Inicio del programa
        while(!salir) {
            //Imprimimos nuestro menu
            menu.imprimirMenu();
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc) {
                case 1: //Iniciar sesion
                    user.inicarSesion();
                    break;
                case 2: //Registrar usuario
                    user.registrarUsuario();
                    break;
                case 3:
                    user.mostrarUsuarios();
                    break;
                case 5: //Sallir del programa
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    continue;
            }
        }
    }
}