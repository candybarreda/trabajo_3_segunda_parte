namespace trabajo_3_segunda_parte
{
    public partial class Form1 : Form
    {
        List<Numero> listaNumeros = new List<Numero>();
        public Form1()
        {
            InitializeComponent();
        }

        private void g_3_ingresar_Click(object sender, EventArgs e)
        {
            if (g_3_numeros.Text == "")
                MessageBox.Show("Existen campos vacios", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                int G_3_numeros = int.Parse(g_3_numeros.Text);


                Numero numero = new Numero();
                numero.G_3_numeros = G_3_numeros;


                listaNumeros.Add(numero);

                ListViewItem lista = getListViewItemByNumero(numero);

                listView_1.Items.Add(lista);

                g_3_numeros.Clear();



            }
        }
        private ListViewItem getListViewItemByNumero(Numero numero)
        {
            ListViewItem lista = new ListViewItem(numero.G_3_numeros.ToString());

            lista.SubItems.Add(numero.G_3_numeros.ToString());

            return lista;
        }

        private void g_3_button_buscar_Click(object sender, EventArgs e)
        {

            string Buscar = g_3_buscar.Text;
            if (Buscar == "")
            {
                MessageBox.Show("Existen campos vacios", " Error");
                return;
            }


            Numero? buscarnumero = listaNumeros.Find((m) =>
             {

                 return m.G_3_numeros == int.Parse(Buscar); ;
             });

            if (buscarnumero == null)

                MessageBox.Show("No se encontro Numero", " Error");
            else
                MessageBox.Show("Se encontro Numero");

            g_3_buscar.Clear();


        }

        private void g_3_eliminar_Click(object sender, EventArgs e)
        {
            string Eliminar = g_3_numelim.Text;




            if (Eliminar == "")
            {
                MessageBox.Show("Existen campos vacios", " Error");
                return;
            }

            int buscarnumero = listaNumeros.FindIndex((m) =>
            {
                return m.G_3_numeros == int.Parse(Eliminar);

            });

            if (buscarnumero == -1)

                MessageBox.Show("Numero no existe", " Error");

            else
            {
                listaNumeros.RemoveAt(buscarnumero);
                listView_1.Items.RemoveAt(buscarnumero);

            }

            g_3_numelim.Clear();


        }
        /*private void eliminarNumeroButton_Click(object sender, EventArgs e)
        {
            int numeroAEliminar = int g_3_numelim; // El número que deseas eliminar

            foreach (ListViewItem item in listView_1.Items)
            {
                int numeroEnItem = int.Parse(item.SubItems[0].Text); // Suponemos que los números están en la primera columna

                if (numeroEnItem == numeroAEliminar)
                {
                    listView_1.Items.Remove(item); // Elimina el elemento que contiene el número deseado
                    break; // Sal del bucle después de eliminar el primer elemento que coincide
                }
            }
        }*/
        private void OrdenarListViewAscendente()
        {
            int n = listView_1.Items.Count;
            bool intercambio;

            do
            {
                intercambio = false;
                for (int i = 0; i < n - 1; i++)
                {
                    ListViewItem item1 = listView_1.Items[i];
                    ListViewItem item2 = listView_1.Items[i + 1];

                    int numero1 = int.Parse(item1.SubItems[0].Text); // Suponemos que el número está en la primera columna
                    int numero2 = int.Parse(item2.SubItems[0].Text);

                    if (numero1 > numero2)
                    {
                        // Realizar un intercambio
                        listView_1.Items.RemoveAt(i);
                        listView_1.Items.Insert(i + 1, item1);
                        intercambio = true;
                    }
                }
            } while (intercambio);

            // La lista ahora está ordenada de forma ascendente
        }

        private void g_3_ascend_Click(object sender, EventArgs e)
        {
            OrdenarListViewAscendente();
        }

        private void OrdenarListViewDescendente()
        {
            int n = listView_1.Items.Count;
            bool intercambio;

            do
            {
                intercambio = false;
                for (int i = 0; i < n - 1; i++)
                {
                    ListViewItem item1 = listView_1.Items[i];
                    ListViewItem item2 = listView_1.Items[i + 1];

                    int numero1 = int.Parse(item1.SubItems[0].Text); // Suponemos que el número está en la primera columna
                    int numero2 = int.Parse(item2.SubItems[0].Text);

                    if (numero1 < numero2)
                    {
                        // Realizar un intercambio
                        listView_1.Items.RemoveAt(i);
                        listView_1.Items.Insert(i + 1, item1);
                        intercambio = true;
                    }
                }
            } while (intercambio);

            // La lista ahora está ordenada de forma descendente
        }

        private void g_3_desendente_Click(object sender, EventArgs e)
        {
            OrdenarListViewDescendente();
        }


    }
}
