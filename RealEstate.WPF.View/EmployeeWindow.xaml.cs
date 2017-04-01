using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace RealEstate.WPF.View
{
    /// <summary>
    /// Логика взаимодействия для WorkerWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {        
        public EmployeeWindow(/*int Access, int Workerid*/)
        {
            InitializeComponent();                         
        }
        ////--------------------------- Кнопка переход по запися ->вперед-------------
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
        //    if (workerDataGrid.SelectedIndex + 1 >= listwork.Count)
        //        workerDataGrid.SelectedIndex = listwork.Count - 1;
        //    else
        //        workerDataGrid.SelectedIndex++;
        }
        ////--------------------------- Кнопка переход по запися ->назад-------------
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {           
        //        if (workerDataGrid.SelectedIndex - 1 <= 0)
        //            workerDataGrid.SelectedIndex = 0;
        //        else
        //            workerDataGrid.SelectedIndex--;                         
        }

        private void chbDostupuvoln_Click(object sender, RoutedEventArgs e)
        {
        //    if (chbDostupuvoln.IsChecked == true)
        //    { key = 1; listwork = (from t in context.Worker.ToList() where t.idStateWorker == 2 select t).ToList(); workerDataGrid.ItemsSource = listwork;
        //    btpostuplenie.Visibility = Visibility.Visible; btuvolnenie.Visibility = Visibility.Hidden; btChange.Visibility = Visibility.Hidden;
        //    btNewWorker.Visibility = Visibility.Hidden;
        //    }
        //    else { key = 0; listwork = (from t in context.Worker.ToList() where t.idStateWorker == 1 select t).ToList(); workerDataGrid.ItemsSource = listwork; btpostuplenie.Visibility = Visibility.Hidden;
        //    btuvolnenie.Visibility = Visibility.Visible; btChange.Visibility = Visibility.Visible;
        //    btNewWorker.Visibility = Visibility.Visible; 
        //    }
        }
        ////---------------------Кнопка Новый сотрудник-----------------------
        private void btNewWorker_Click(object sender, RoutedEventArgs e)
        {
        //    btnBrowse.Visibility = Visibility.Visible;
        //    cbPost.Text = "";
        //    surnameTextBox.Text = "";
        //    nameTextBox.Text = "";
        //    patronymicTextBox.Text = "";
        //    addressTextBox.Text = "";
        //    passportTextBox.Text = "";
        //    phoneNumTextBox.Text = "";
        //    emailTextBox.Text = "";
        //    loginTextBox.Text = "";
        //    passwordTextBox.Text = "";
        //    Image.Source = new BitmapImage(new Uri("file:///D:/курсач с%23 2.1/RealEstate.WPF.View/blue.gif"));
        //    cbStateWorker.SelectedIndex = 0;
        //    tbdatep.Text = DateTime.Now.ToShortDateString();
        //    btNewWorker.Visibility = Visibility.Hidden;
        //    btSaveWorker.Visibility = Visibility.Visible;
        //    btChange.Visibility = Visibility.Hidden;
        //    btuvolnenie.Visibility = Visibility.Hidden;
        //    redostup();
            
        }
        ////---------------------запись в объект с полей--------------------
        private /*Worker*/void GetWorker(/*Worker woker*/)
        {
        //    Dolgnost r = (from f in context.Dolgnost where f.Name == cbPost.Text select f).FirstOrDefault();
        //    woker.DolgnostID = r.DolgnostID;
        //    if (count == 1)
        //        woker.idStateWorker = 2;
        //    else {
        //        woker.idStateWorker = 1;
        //    }
        //    woker.Surname = surnameTextBox.Text;
        //    woker.Name = nameTextBox.Text;
        //    woker.Patronymic = patronymicTextBox.Text;
        //    woker.Address = addressTextBox.Text;
        //    woker.Passport = passportTextBox.Text;
        //    woker.PhoneNum = phoneNumTextBox.Text;
        //    woker.Email = emailTextBox.Text;
        //    woker.login = loginTextBox.Text;
        //    woker.password = passwordTextBox.Text;
        //    if (Image.Source.ToString() == "")
        //        woker.Image = Image.Source.ToString();
        //    else { }
        //    return woker;
        }
        private /*Uvolnenie*/void GetUvoln(/*Uvolnenie uvoln*/) 
        {

        //    if (count == 1)
        //    {
        //        uvoln.empFireDate = tbdateu.Text;
        //        uvoln.emplDate = tbdatep.Text;
        //    }
        //    else
        //    {
        //        uvoln.WokerID = id;
        //        if (count == 0)
        //            uvoln.emplDate = DateTime.Now.ToShortDateString();
        //    }
        //    return uvoln;
        }
        ////------------------- Кнопка сохранения---------------------------
        private void btSaveWorker_Click(object sender, RoutedEventArgs e)
        {       //Worker worker=new Worker();
        //        Uvolnenie uvoln = new Uvolnenie();
        //        GetWorker(worker);
        //        ImageCopy(worker);
        //        context.Worker.Add(worker);
        //        context.SaveChanges();
        //        MessageBox.Show("Запись сохранена");
        //        var workerList = new List<Worker>();
        //        workerList = context.Worker.ToList();
        //        id = (int)workerList[workerList.Count() - 1].WokerID;
        //        GetUvoln(uvoln);
        //        context.Uvolnenie.Add(uvoln);
        //        context.SaveChanges();
        //        if (key == 1)
        //        { listwork = (from t in context.Worker.ToList() where t.idStateWorker == 2 select t).ToList(); }
        //        else { listwork = (from t in context.Worker.ToList() where t.idStateWorker == 1 select t).ToList(); }
        //        workerDataGrid.ItemsSource = listwork;
        //        btNewWorker.Visibility = Visibility.Visible;
        //        btSaveWorker.Visibility = Visibility.Hidden;
        //        btChange.Visibility = Visibility.Visible;
        //        btuvolnenie.Visibility = Visibility.Hidden;
        //        btnBrowse.Visibility = Visibility.Hidden;
         }

        ////--------------------Кнопка загрузить--------------------------------
        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {

            //        if (context.Worker.ToList().Count == 0)
            //            MessageBox.Show("Этого сотрудника еще нет");
            //        else
            //        {
            //            OpenFileDialog dialog = new OpenFileDialog();
            //            dialog.Filter = "Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            //            Nullable<bool> result = dialog.ShowDialog();
            //            if (result == true)
            //            {
            //                try
            //                {
            //                    Image.Source = new BitmapImage(new Uri(dialog.FileName));
            //                }
            //                catch (Exception ex)
            //                {
            //                    MessageBox.Show(ex.Message);
            //                } } } 
        }
        ////----------------------Копирования фото---------------------------
        private void ImageCopy(/*Worker worker*/)
        {
        //    string path = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\Images";
        //    if (!Directory.Exists(path))
        //    {
        //        Directory.CreateDirectory(path);
        //    }
        //    if (Image.Source != null)
        //    {
        //        string localFilePath = new Uri(Image.Source.ToString()).LocalPath;
        //        File.Copy(localFilePath,
        //        AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\Images\" +
        //        System.IO.Path.GetFileName(localFilePath), true);
        //        worker.Image = @"\Images\" +
        //        System.IO.Path.GetFileName(localFilePath);
        //    }
        }
        ////----------------Заполнение comboBox и картинки при загрузке формы------------------ 
        private void ChangePost(long a)
        {
                         
        //       currentPost = (Dolgnost)((from p in context.Worker
        //                                  where p.WokerID == a
        //                                  select p.Dolgnost).FirstOrDefault());
        //        cbPost.Text = currentPost.Name;

        //        currentState = (StateWoker)((from s in context.Worker
        //                                  where s.WokerID == a
        //                                     select s.StateWoker).FirstOrDefault());
        //        cbStateWorker.Text = currentState.Name;

        //        var h = (from p in context.Dogovor where p.WokerID == a select p); 
        //        tbcountdog.Text = h.Count().ToString();
        //        dogovorDataGrid.ItemsSource = h.ToList();
        //        dogovorDataGrid.SelectedIndex = 0;
        //        float cost = 0;
        //        foreach (var f in h)
        //        {
        //            cost += (float)f.PriceNedvigimosty; 
        //        }
        //        tbcountprice.Text = cost.ToString(); 
        //        if (((Worker)workerDataGrid.SelectedItem).Image != "")
        //        {
        //            try
        //            {
        //                { Image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory.ToString() + ((Worker)workerDataGrid.SelectedItem).Image)); }
                       
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message + "+");
        //            }
        //        }
        //        else
        //        {
        //            Image.Source = null;
        //        }
        }       
        ////-------------------Заполнение ComboBox-------------------------
        private void FillPosts()
        {
            
        //        var posts = from p in context.Dolgnost select p;
        //        foreach (Dolgnost post in posts)
        //        {
        //            cbPost.Items.Add(post.Name);
        //            cbSearchDolgnost.Items.Add(post.Name);
        //        }
        //        var state = from p in context.StateWoker select p;
        //        foreach (StateWoker st in state)
        //        {
        //            cbStateWorker.Items.Add(st.Name);
                    
        //        }
        //        var Typed = from k in context.TypeDogovora select k;
        //        foreach (TypeDogovora pd in Typed)
        //        {
        //            cbfilttyped.Items.Add(pd.Name);

        //        }
            
        }
        ////----------------Кнопка назад-------------------------
        private void btnbkpage_Click(object sender, RoutedEventArgs e)
        {
        //    MainWindow w = new MainWindow(Acs, WID);
        //    w.Show();
        //    this.Close();
        }
        ////---------------------Заполнение TextBox ----------------------
        private void FillWorker(long a)
        {         
        //    var worker = (from t in context.Worker where t.WokerID == a select t);
        //    foreach (var v in worker)
        //    {
        //        surnameTextBox.Text = v.Surname;
        //        nameTextBox.Text = v.Name;
        //        patronymicTextBox.Text = v.Patronymic;
        //        addressTextBox.Text = v.Address;
        //        passportTextBox.Text = v.Passport;
        //        phoneNumTextBox.Text = v.PhoneNum;
        //        emailTextBox.Text = v.Email;
        //        loginTextBox.Text = v.login;
        //        passwordTextBox.Text = v.password;                
         //   }
           
         //   var postuplenie = (from t in context.Uvolnenie where t.WokerID == a select t);
        //    foreach (var r in postuplenie)
        //         { tbdatep.Text = r.emplDate;
        //         tbdateu.Text = r.empFireDate; 
        //    }     
        }
        ////---------------------Свойство ДатаГрида перехода по записям---------------------
        private void workerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        //        if (workerDataGrid.SelectedIndex >= 0)
        //        {
        //            long a = ((Worker)workerDataGrid.SelectedItem).WokerID;
        //            FillWorker(a);
        //            ChangePost(a);
        //            id=(int)a;
        //        }
        //        else
        //        {
        //            workerDataGrid.SelectedIndex = 0;
        //        }
        }  
        ////------------------Кнопка Сохранить Изменения----------------------
        private void btSaveChange_Click(object sender, RoutedEventArgs e)
        {                       
        //            Worker worker = (from w in context.Worker where w.WokerID == id select w).FirstOrDefault();
        //            GetWorker(worker);//заполняем поля формы с выбранныи индексом
        //            context.SaveChanges();//сохраняем изменения
        //            MessageBox.Show("Изменения сохранены");
        //            if (key == 1)
        //            { listwork = (from t in context.Worker.ToList() where t.idStateWorker == 2 select t).ToList(); }
        //            else { listwork = (from t in context.Worker.ToList() where t.idStateWorker == 1 select t).ToList(); }
        //            workerDataGrid.ItemsSource = listwork;
        //            dostup();
        //            btnBrowse.Visibility = Visibility.Hidden;
        //            btChange.Visibility = Visibility.Visible;
        //            btSaveChange.Visibility = Visibility.Hidden;
            }
        ////---------------------Кнопка поиск по ФИО-------------------------------
        private void btSearchWorker_Click(object sender, RoutedEventArgs e)
        {
               
        //        workerDataGrid.ItemsSource = listwork;
        //        int count = 0;
        //        string a = "";
        //        string b = "";
        //        string c = "";           
        //        for (int i = 0; i < tbSearchWorker.Text.Length; i++)
        //        {
        //            if (tbSearchWorker.Text[i] == ' ' && tbSearchWorker.Text[i + 1] == ' ')                   
        //                MessageBox.Show("error");                   
        //        }
        //        for (int i = 0; i < tbSearchWorker.Text.Length; i++)
        //        {
        //            if (tbSearchWorker.Text[i] == ' ')
        //                count++;
        //            else
        //            {
        //                switch (count)
        //                {
        //                    case (0): { a += tbSearchWorker.Text[i]; break; }
        //                    case (1): { b += tbSearchWorker.Text[i]; break; }
        //                    case (2): { c += tbSearchWorker.Text[i]; break; }
        //                }

        //            }
        //        }
        //        switch (count)
        //        {
        //        case (0):
        //            {
        //                    var worker = (from t in listwork where t.Name == a || t.Surname == a || t.Patronymic == a select t);
        //                    if (worker.Count() == 0) { MessageBox.Show("Этого сотрудника нет в Базе Данных"); break; }

        //                    workerDataGrid.ItemsSource = worker;
        //                    workerDataGrid.SelectedIndex = 0;
        //                    break;
        //            }
        //        case (1):
        //            {
        //                    var worker1 = (from t in listwork
        //                    where (t.Surname == a && t.Name == b) ||(t.Name == a && t.Surname == b) || (t.Name == a && t.Patronymic == b) select t);
        //                    if (worker1.Count() == 0) { MessageBox.Show("Этого сотрудника нет в Базе Данных"); break; }

        //                    workerDataGrid.ItemsSource = worker1;
        //                    workerDataGrid.SelectedIndex = 0;
        //                    break;
        //            }
        //        case (2):
        //            {                          
        //                    var worker2 = (from t in listwork where (t.Name == b && t.Surname == a && t.Patronymic == c) select t);
        //                    if (worker2.Count() == 0) { MessageBox.Show("Этого сотрудника нет в Базе Данных"); break; }
                            
        //                    workerDataGrid.ItemsSource = worker2;
        //                    workerDataGrid.SelectedIndex = 0;
        //                    break;
        //            }
        //        }
            }
        
        private void tbDatepost_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
        //    tbdatep.Text = tbDatepost.SelectedDate.Value.ToShortDateString();
        }
        private void dpfiltrecords_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
        //    tbfiltrecords.Text = dpfiltrecords.SelectedDate.Value.ToShortDateString();
        }
        private void dpfiltrecordpo_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
        //    tbfiltrecordpo.Text = dpfiltrecordpo.SelectedDate.Value.ToShortDateString();
        }
        private void tbDateuvoln_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
        //    tbdateu.Text = tbDateuvoln.SelectedDate.Value.ToShortDateString();
        }
        private void cbSearchDolgnost_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        //    if (key == 1)
        //    { listwork = (from t in context.Worker.ToList() where t.idStateWorker == 2 select t).ToList(); }
        //    else { listwork = (from t in context.Worker.ToList() where t.idStateWorker == 1 select t).ToList();}
        //    workerDataGrid.ItemsSource = listwork;
        //       if (cbSearchDolgnost.SelectedValue != null)
        //       {
        //           var o = (from f in context.Dolgnost where f.Name == (string)cbSearchDolgnost.SelectedValue select f);
        //           foreach (var n in o)
        //           {
        //               var v = (from l in listwork where l.DolgnostID == n.DolgnostID select l);
        //               if (v.Count() != 0)
        //               {
        //                   workerDataGrid.ItemsSource = v;
        //                   listwork = v.ToList();
        //               }
        //               else
        //               {
        //                   workerDataGrid.ItemsSource = v;
        //                   MessageBox.Show("Сотрудника нет в базе данных");
        //               }
        //           }
        //       }
               
            
        }
        private void cbfilttyped_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        //    Filldogovor();
        //    tbcountdog.Text = dogovorDataGrid.Items.Count.ToString();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
        //    Filldogovor();
        //    tbcountdog.Text = dogovorDataGrid.Items.Count.ToString();
        }
        private void Filldogovor() {
            
        //        long a = ((Worker)workerDataGrid.SelectedItem).WokerID;
        //        List<Dogovor> h = (from p in context.Dogovor where p.WokerID == a select p).ToList();
        //        dogovorDataGrid.ItemsSource = h;
        //        if (cbfilttyped.SelectedValue != null)
        //        {
        //            var o = (from f in context.TypeDogovora where f.Name == (string)cbfilttyped.SelectedValue select f);
        //            foreach (var n in o)
        //            {
        //                var v = (from l in h where l.IDTypeDogovora == n.IDTypeDogovora select l);
        //                if (v.Count() != 0)
        //                {
        //                    dogovorDataGrid.ItemsSource = v;
        //                    h = v.ToList();
        //                }
        //                else
        //                {
        //                    dogovorDataGrid.ItemsSource = v;
        //                    dogovorDataGrid.SelectedItem = 0;
        //                    MessageBox.Show("ContractWindowа нет в базе данных");
        //                }
        //            }
        //        }
                
        //        if (tbfiltrecords.Text != "")
        //        {
        //            var v = (from l in h where Convert.ToDateTime(l.DateRecord) >= Convert.ToDateTime(tbfiltrecords.Text) select l);
        //                if (v.Count() != 0)
        //                {
        //                    dogovorDataGrid.ItemsSource = v;
        //                    h = v.ToList();
        //                }
        //                else
        //                {
        //                    dogovorDataGrid.ItemsSource = v;
        //                    dogovorDataGrid.SelectedItem = 0;
        //                    MessageBox.Show("ContractWindowа нет в базе данных");
        //                }                    
        //        }
               
        //        if (tbfiltrecordpo.Text != "")
        //        {
        //            var v = (from l in h where Convert.ToDateTime(l.DateRecord) <= Convert.ToDateTime(tbfiltrecordpo.Text) select l);
        //                if (v.Count() != 0)
        //                {
        //                    dogovorDataGrid.ItemsSource = v;
        //                    h = v.ToList();
        //                }
        //                else
        //                {
        //                    dogovorDataGrid.ItemsSource = v;
        //                    dogovorDataGrid.SelectedItem = 0;
                            
        //                    MessageBox.Show("ContractWindowа нет в базе данных");
        //                }
        //             }
                               
        }

        private void btuvolnenie_Click(object sender, RoutedEventArgs e)
        {
        //    count = 1;
        //    tbdateu.Text = DateTime.Now.ToShortDateString();
        //    Worker worker = (from w in context.Worker where w.WokerID == id select w).FirstOrDefault();
        //    Uvolnenie uvoln = (from u in context.Uvolnenie where u.WokerID == id select u).FirstOrDefault();
        //    GetUvoln(uvoln);
        //    context.SaveChanges();
        //    GetWorker(worker);
        //    context.SaveChanges();
        //    MessageBox.Show("Сотрудник уволен");
        //    if (key == 1)
        //    { listwork = (from t in context.Worker.ToList() where t.idStateWorker == 2 select t).ToList(); }
        //    else { listwork = (from t in context.Worker.ToList() where t.idStateWorker == 1 select t).ToList(); }
        //    workerDataGrid.ItemsSource = listwork;
        }

        private void btpostuplenie_Click(object sender, RoutedEventArgs e)
        {
        //    count = 0;
        //    Uvolnenie uvoln = new Uvolnenie();
        //    Worker worker = (from w in context.Worker where w.WokerID == id select w).FirstOrDefault();
        //    GetUvoln(uvoln);
        //    context.Uvolnenie.Add(uvoln);
        //    context.SaveChanges();
        //    GetWorker(worker);
        //    context.SaveChanges();
        //    MessageBox.Show("Сотрудник возобновлен");
        //    if (key == 1)
        //    { listwork = (from t in context.Worker.ToList() where t.idStateWorker == 2 select t).ToList(); }
        //    else { listwork = (from t in context.Worker.ToList() where t.idStateWorker == 1 select t).ToList(); }
        //    workerDataGrid.ItemsSource = listwork;
        }

      

        private void dogovorDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        //    if (dogovorDataGrid.SelectedIndex >= 0)
        //    {
        //        int a = (int)((Dogovor)dogovorDataGrid.SelectedItem).idDogovora;
        //        ContractWindow dog = new ContractWindow(Acs,0,cCln,CNed,a);
        //        dog.Show();
        //    }
        //    else
        //    {
        //        dogovorDataGrid.SelectedIndex = 0;
        //    }
            
        }

        private void dostup()
        {
        //    surnameTextBox.IsReadOnly = true;
        //    nameTextBox.IsReadOnly = true;
        //    patronymicTextBox.IsReadOnly = true;
        //    addressTextBox.IsReadOnly = true;
        //    passportTextBox.IsReadOnly = true;
        //    phoneNumTextBox.IsReadOnly = true;
        //    emailTextBox.IsReadOnly = true;
        //    loginTextBox.IsReadOnly = true;
        //    passwordTextBox.IsReadOnly = true;
            
        }
        private void redostup()
        {
        //    surnameTextBox.IsReadOnly = false;
        //    nameTextBox.IsReadOnly = false;
        //    patronymicTextBox.IsReadOnly = false;
        //    addressTextBox.IsReadOnly = false;
        //    passportTextBox.IsReadOnly = false;
        //    phoneNumTextBox.IsReadOnly = false;
        //    emailTextBox.IsReadOnly = false;
        //    loginTextBox.IsReadOnly = false;
        //    passwordTextBox.IsReadOnly = false;
           
        }

        private void btChange_Click(object sender, RoutedEventArgs e)
        {
        //    redostup();
        //    btnBrowse.Visibility = Visibility.Visible;
        //    btChange.Visibility = Visibility.Hidden;
        //    btSaveChange.Visibility = Visibility.Visible;
        }

       
    }
}

    
