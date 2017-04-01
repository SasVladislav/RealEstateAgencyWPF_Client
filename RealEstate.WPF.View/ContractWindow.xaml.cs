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
    /// Логика взаимодействия для ContractWindow.xaml
    /// </summary>
    public partial class ContractWindow : Window
    {
       //public Dogovor dog = new Dogovor();
       // Nedvigimost nedv = new Nedvigimost();
       // Client clnt = new Client();
       // Worker work = new Worker();
       // private TypeNedvigimosti currentNedv = new TypeNedvigimosti();
       // private TypeWall currentWall = new TypeWall();
       // private ClassNedvigimosti currentClass = new ClassNedvigimosti();
       // private Client cCln;
       // private Nedvigimost CNed;
       // int id = 0;
       // private int CID = 0;
       // private int NID = 0;
       // private int WID = 0;
       // private int Acs = 0;
        public ContractWindow(/*int Access, int Workerid, Client currCLN, Nedvigimost currNed, int d*/)
        {
            //id = d;
            InitializeComponent();
            //Acs = Access;
            //WID = Workerid;
            //CNed = currNed;
            //cCln = currCLN;

            //using (AgencyDbEntities context = new AgencyDbEntities())
            //{
            //    tbDareRecord.Text = DateTime.Now.ToShortDateString();
            //    Fill();
            //    btBack.Visibility = Visibility.Visible;
                
            //    if (WID != 0)
            //    {
            //        Worker infoWorker = (from ifw in context.Worker where ifw.WokerID == WID select ifw).FirstOrDefault();
            //        FillWorker(infoWorker);
            //    }
            //    if (d != 0)
            //    {
            //        FillDogovor(d);
            //        btBack.Visibility = Visibility.Hidden;
            //    }
            //    if (CNed.Price != 0)
            //    {
            //        GetNedvig(CNed);
            //        FillNedv(CNed);
            //        TypeDogovora inftypeD = (from infd in context.TypeDogovora where infd.IDTypeDogovora == 1 select infd).FirstOrDefault();
            //        tbTypeDogv.Text = inftypeD.Name;
            //        Fill();
            //    }

            //    if (cCln.PhoneNum != 0)
            //    {
            //        GetClient(cCln);
            //        EnPoleCln();
            //    }

            //}
        }
        //private void FillWorker(Worker infoWorker)
        //{
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        surnameTextBox.Text = infoWorker.Surname;
        //        nameTextBox.Text = infoWorker.Name;
        //        patronymicTextBox.Text = infoWorker.Patronymic;
        //        Dolgnost infoDolg = (from ifd in context.Dolgnost where ifd.DolgnostID == infoWorker.DolgnostID select ifd).FirstOrDefault();
        //        tbDolgnost.Text = infoDolg.Name;
        //    }
        //}
        private void FillDogovor(int d)
        { 
        //using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        Dogovor dog = (from f in context.Dogovor where f.idDogovora == d select f).FirstOrDefault();
        //        Nedvigimost nedv = (from f in context.Nedvigimost where f.IDNedvigimosti == dog.IDNedvigimosty select f).FirstOrDefault();
        //        Client clnt = (from f in context.Client where f.ClientID == dog.IDClienta select f).FirstOrDefault();
        //        Worker work = (from f in context.Worker where f.WokerID == dog.WokerID select f).FirstOrDefault();
        //        GetNedvig(nedv);
        //        FillNedv(nedv);
        //        GetClient(clnt);
        //        FillWorker(work);
        //        TypeDogovora inftypeD = (from infd in context.TypeDogovora where infd.IDTypeDogovora == dog.IDTypeDogovora select infd).FirstOrDefault();
        //        tbTypeDogv.Text = inftypeD.Name;
        //    }
        }
        ////-----------------Запись с объекта Недвижимости в Поля---------------------
        private void GetNedvig(/*Nedvigimost CNed*/)
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        cbTypeN.Text = CNed.idTypeNedvigimosti.ToString();
        //        cbTypeW.Text = CNed.idTypeWall.ToString();
        //        tbnumberOfRooms.Text = CNed.NumberOfRooms.ToString();
        //        levelTextBox.Text = CNed.Level.ToString();
        //        tbgrossArea.Text = CNed.GrossArea.ToString();
        //        tbnearSusway.Text = CNed.NearSusway;
        //        //cblift.Text=CurrNedv.Lift;
        //        cbClass.Text = CNed.idClassHome.ToString();
        //        tbcity.Text = CNed.City;
        //        tbregion.Text = CNed.Region;
        //        tbstreet.Text = CNed.Street;
        //        tbhomeNomber.Text = CNed.HomeNomber.ToString();
        //        tbapartmentNomber.Text = CNed.ApartmentNomber.ToString();
        //        tbprice.Text = CNed.Price.ToString();
        //        if(id!=0)
        //        Image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory.ToString() + CNed.image));
        //        else Image.Source = new BitmapImage(new Uri(CNed.image));
        //    }
        }
        ////-----------------Запись с полей Недвижимости в объект---------------------
        private void GetNedvigimost(/*Nedvigimost nedv*/)
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        TypeNedvigimosti q = (from f in context.TypeNedvigimosti where f.Name == cbTypeN.Text select f).FirstOrDefault();
        //        TypeWall e = (from f in context.TypeWall where f.Name == cbTypeW.Text select f).FirstOrDefault();
        //        ClassNedvigimosti r = (from f in context.ClassNedvigimosti where f.Name == cbClass.Text select f).FirstOrDefault();
        //        nedv.idTypeNedvigimosti = q.idTypeNedvigimosti;
        //        if (CNed.IDNedvigimosti != 0)
        //        { nedv.idStateNedvigimosti = 2; }
        //        else { nedv.idStateNedvigimosti = 1; }
        //        nedv.idTypeWall = e.idTypeWall;
        //        nedv.idClassHome = r.idClassNedvigimosti;
        //        nedv.Price = Convert.ToInt32(tbprice.Text);
        //        nedv.NumberOfRooms = Convert.ToInt32(tbnumberOfRooms.Text);
        //        nedv.Level = Convert.ToInt32(levelTextBox.Text);
        //        nedv.GrossArea = Convert.ToInt32(tbgrossArea.Text);
        //        nedv.NearSusway = tbnearSusway.Text;
        //        nedv.Lift = 0;
        //        nedv.City = tbcity.Text;
        //        nedv.Region = tbregion.Text;
        //        nedv.Street = tbstreet.Text;
        //        nedv.HomeNomber = Convert.ToInt32(tbhomeNomber.Text);
        //        if (cbTypeN.SelectedIndex != 1)
        //        { }
        //        else
        //        nedv.ApartmentNomber = Convert.ToInt32(tbapartmentNomber.Text);
        //        if (CNed.IDNedvigimosti != 0)
        //        { }
        //        else
        //        nedv.image = Image.Source.ToString();
        //        return nedv;
        //    }
        }
        ////-----------------Кнопка добавить недвижимость---------------------
        private void btAddNedv_Click(object sender, RoutedEventArgs e)
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {              
        //        TypeDogovora inftypeD = (from infd in context.TypeDogovora where infd.IDTypeDogovora == 2 select infd).FirstOrDefault();
        //        tbTypeDogv.Text = inftypeD.Name;
        //        cbTypeN.IsEnabled = true;
        //        cbTypeW.IsEnabled = true;
        //        tbnumberOfRooms.IsReadOnly = false;
        //        levelTextBox.IsReadOnly = false;
        //        tbgrossArea.IsReadOnly = false;
        //        tbnearSusway.IsReadOnly = false;
        //        cblift.IsEnabled = true;
        //        cbClass.IsEnabled = true;
        //        tbcity.IsReadOnly = false;
        //        tbregion.IsReadOnly = false;
        //        tbstreet.IsReadOnly = false;
        //        tbhomeNomber.IsReadOnly = false;
        //        tbapartmentNomber.IsReadOnly = false;
        //        tbprice.IsReadOnly = false;
        //        tbSearchNedv.IsEnabled = false;
        //        btAddNedv.IsEnabled = false;
        //        btnBrowse.IsEnabled = true;
        //        CleanPole.IsEnabled = true;
        //        Image.Source = new BitmapImage(new Uri("file:///D:/курсач с%23 2.1/RealEstate.WPF.View/blue.gif"));
        //    }
        }

        ////-----------------Кнопка найти Недвижимость---------------------
        private void tbSearchNedv_Click(object sender, RoutedEventArgs e)
        {
        //    if (tbPass.Text != "")
        //    {
        //        GetCln(cCln);
        //    }
        //    RealEstateWindow w4 = new RealEstateWindow(Acs, WID, cCln, CNed);
        //    w4.Show();
        //    this.Close();
        }
        ////-----------------Очистить поля Недвижимости---------------------
        private void CleanPole_Click(object sender, RoutedEventArgs e)
        {
        //    CNed.IDNedvigimosti = 0;
        //    cbTypeN.Text = "";
        //    cbTypeW.Text = "";
        //    tbnumberOfRooms.Text = "";
        //    levelTextBox.Text = "";
        //    tbgrossArea.Text = "";
        //    tbnearSusway.Text = "";
        //    cblift.IsChecked = false;
        //    cbClass.Text = "";
        //    tbcity.Text = "";
        //    tbregion.Text = "";
        //    tbstreet.Text = "";
        //    tbhomeNomber.Text = "";
        //    tbapartmentNomber.Text = "";
        //    tbprice.Text = "";
        //    Image.Source = null;
        //    tbSearchNedv.IsEnabled = true;
        //    btAddNedv.IsEnabled = true;
        //    btnBrowse.IsEnabled = false;
        //    CleanPole.IsEnabled = false;
        //    EnPole();
        }
        ////-----------------Заполнение ComboBox-в данными ---------------------
        private void Fill()
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        var TypeN = from t in context.TypeNedvigimosti select t;
        //        var Wall = from w in context.TypeWall select w;
        //        var Class = from c in context.ClassNedvigimosti select c;
        //        foreach (TypeNedvigimosti Typel in TypeN) { cbTypeN.Items.Add(Typel.Name); }
        //        foreach (TypeWall TypeW in Wall) { cbTypeW.Items.Add(TypeW.Name); }
        //        foreach (ClassNedvigimosti Cl in Class) { cbClass.Items.Add(Cl.Name); }
        //    }
        }
        private void FillNedv(/*Nedvigimost CNed*/)
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        TypeNedvigimosti currentNed = (from t in context.TypeNedvigimosti where t.idTypeNedvigimosti == CNed.idTypeNedvigimosti select t).FirstOrDefault();
        //        cbTypeN.Text = currentNed.Name;
        //        currentWall = (from t in context.TypeWall where t.idTypeWall == CNed.idTypeWall select t).FirstOrDefault();
        //        cbTypeW.Text = currentWall.Name;
        //        currentClass = (from t in context.ClassNedvigimosti where t.idClassNedvigimosti == CNed.idClassHome select t).FirstOrDefault();
        //        cbClass.Text = currentClass.Name;
        //        if (CNed.image == "")
        //        {
        //            Image.Source = null;
        //            return;
        //        }
        //        else
        //            try
        //            {
        //                Image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory.ToString() + CNed.image));
        //            }
        //            catch (Exception ex)
        //            {
        //                //MessageBox.Show(ex.Message + "+");
        //            }
        //    }
        }
        ////-----------------Кнопка Загрузить---------------------
        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        if (context.Nedvigimost.ToList().Count == 0)
        //            MessageBox.Show("There's no nedvigimost yet");
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
        //                }
        //            }
        //        }
        //    }
        }
        private void ImageCopy(/*Nedvigimost ned*/)
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
        //        ned.image =@"\Images\" +
        //        System.IO.Path.GetFileName(localFilePath);
        //    }
        }
        ////-----------------Блокировка полей Недвижимости---------------------
        private void EnPole()
        {
        //    cbTypeN.IsReadOnly = true;
        //    cbTypeW.IsReadOnly = true;
        //    tbnumberOfRooms.IsReadOnly = true;
        //    levelTextBox.IsReadOnly = true;
        //    tbgrossArea.IsReadOnly = true;
        //    tbnearSusway.IsReadOnly = true;
        //    //cblift.IsReadOnly = true;
        //    cbClass.IsReadOnly = true;
        //    tbcity.IsReadOnly = true;
        //    tbregion.IsReadOnly = true;
        //    tbstreet.IsReadOnly = true;
        //    tbhomeNomber.IsReadOnly = true;
        //    tbapartmentNomber.IsReadOnly = true;
        //    tbprice.IsReadOnly = true;

        }
        ////-----------------Метод проверки на совпадение Клиента---------------------
        private void ControlNedv()
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        List<Nedvigimost> ListNedv = context.Nedvigimost.ToList();
        //        if (tbcity.Text != "" && tbregion.Text != "" && tbstreet.Text != "" && tbhomeNomber.Text != "")
        //        {
        //            List<Nedvigimost> Nd = (from n in ListNedv
        //                                    where tbcity.Text == n.City && tbregion.Text == n.Region &&
        //                                     tbstreet.Text == n.Street && tbhomeNomber.Text == n.HomeNomber.ToString()
        //                               select n).ToList();
        //            if (Nd.Count() != 0)
        //            { if (id != 0) { } else { MessageBox.Show("Такая недвижимость есть в базе данных");} btsave.IsEnabled = false; label17.Content = "-"; label18.Content = "-"; label19.Content = "-"; label20.Content = "-";  }
        //            else { btsave.IsEnabled = true; label17.Content = "+"; label18.Content = "+"; label19.Content = "+"; label20.Content = "+"; }

        //        }
        //        else { btsave.IsEnabled = true; label13.Content = ""; label14.Content = ""; label15.Content = ""; label16.Content = ""; }
        //    }
        }
        private void tbcity_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        //    if (CNed.IDNedvigimosti == 0 && dog.IDClienta == 0)
        //    ControlNedv();
        }

        private void tbregion_TextChanged(object sender, TextChangedEventArgs e)
        {
        //    if (CNed.IDNedvigimosti == 0 && dog.IDClienta == 0)
        //    ControlNedv();
        }

        private void tbstreet_TextChanged(object sender, TextChangedEventArgs e)
        {
        //    if (CNed.IDNedvigimosti == 0 && dog.IDClienta == 0)
        //    ControlNedv();
        }

        private void tbhomeNomber_TextChanged(object sender, TextChangedEventArgs e)
        {
        //    if (CNed.IDNedvigimosti == 0 && dog.IDClienta == 0)
        //    ControlNedv();
        }

        private void tbapartmentNomber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        ////-----------------Блокировка полей Клиента---------------------
        private void EnPoleCln()
        {
        //    tbSurname.IsReadOnly = true;
        //    tbName.IsReadOnly = true;
        //    tbPatronymic.IsReadOnly = true;
        //    tbPhone.IsReadOnly = true;
        //    tbMail.IsReadOnly = true;
        //    tbPass.IsReadOnly = true;

        }
        ////-----------------Запись с объекта Клиента в поля---------------------
        private void GetClient(/*Client cCln*/)
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        tbSurname.Text = cCln.Surname;
        //        tbName.Text = cCln.Name;
        //        tbPatronymic.Text = cCln.Patronymic;
        //        tbPhone.Text = cCln.PhoneNum.ToString();
        //        tbMail.Text = cCln.Email;
        //        tbPass.Text = cCln.PassNum;

        //    }
        }
        ////-----------------Запись с полей Клиента в объект---------------------
        private /*Client*/ void GetCln(/*Client client*/)
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        client.Name = tbName.Text;
        //        client.Surname = tbSurname.Text;
        //        client.Patronymic = tbPatronymic.Text;
        //        client.PhoneNum = Convert.ToInt64(tbPhone.Text);
        //        client.Email = tbMail.Text;
        //        client.PassNum = tbPass.Text;
        //        return client;
        //    }
        }
        ////-----------------Очистить поля Клиента---------------------
        private void ClearCln_Click(object sender, RoutedEventArgs e)
        {
        //    cCln.ClientID = 0;
        //    tbSurname.Text = "";
        //    tbName.Text = "";
        //    tbPatronymic.Text = "";
        //    tbPhone.Text = "";
        //    tbMail.Text = "";
        //    tbPass.Text = "";
        //    tbSearchClient.IsEnabled = true;
        //    btAddClient.IsEnabled = true;
        //    ClearCln.IsEnabled = false;
        //    EnPoleCln();
        }
        ////-----------------Кнопка Добавить Клиента---------------------
        private void btAddClient_Click(object sender, RoutedEventArgs e)
        {
        //    tbSurname.IsReadOnly = false;
        //    tbName.IsReadOnly = false;
        //    tbPatronymic.IsReadOnly = false;
        //    tbPhone.IsReadOnly = false;
        //    tbMail.IsReadOnly = false;
        //    tbPass.IsReadOnly = false;
        //    tbSearchClient.IsEnabled = false;
        //    btAddClient.IsEnabled = false;
        //    ClearCln.IsEnabled = true;

        }
        ////-----------------Кнопка найти Клиент---------------------
        private void tbSearchClient_Click(object sender, RoutedEventArgs e)
        {
        //    if (levelTextBox.Text != "")
        //    { GetNedvigimost(CNed); }
        //    ClientWindow w1 = new ClientWindow(Acs, WID, cCln, CNed);
        //    w1.Show();
        //    this.Close();
        }
        ////-----------------Метод проверки на совпадение Клиента---------------------
        private void ControlCln()
        {
            //using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //    List<Client> ListCln = context.Client.ToList();
        //        if (tbSurname.Text != "" && tbName.Text != "" && tbPatronymic.Text != "" && tbPass.Text != "")
        //         {
        //            List<Client> Cl = (from c in ListCln 
        //            where tbSurname.Text == c.Surname && tbName.Text == c.Name && 
        //                  tbPatronymic.Text == c.Patronymic && tbPass.Text== c.PassNum select c).ToList();
        //            if (Cl.Count() != 0)
        //            { if (id != 0) { } else { MessageBox.Show("Такой клиент есть в базе данных");} btsave.IsEnabled = false; label13.Content = "-"; label14.Content = "-"; label15.Content = "-"; label16.Content = "-"; }
        //            else { btsave.IsEnabled = true; label13.Content = "+"; label14.Content = "+"; label15.Content = "+"; label16.Content = "+"; } 
            
        //        }
        //        else { btsave.IsEnabled = true; label13.Content = ""; label14.Content = ""; label15.Content = ""; label16.Content = ""; }
        //    }
        }
        

        private void tbSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
        //    if(cCln.ClientID==0 && dog.IDClienta==0 )
        //    ControlCln();
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
        //    if (cCln.ClientID == 0 && dog.IDClienta == 0)
        //    ControlCln();
        }

        private void tbPatronymic_TextChanged(object sender, TextChangedEventArgs e)
        {
        //    if (cCln.ClientID == 0 && dog.IDClienta == 0)
        //    ControlCln();
        }

        private void tbPass_TextChanged(object sender, TextChangedEventArgs e)
        {
        //    if (cCln.ClientID == 0 && dog.IDClienta == 0)
        //    ControlCln();
        }
        ////-----------------Запись с полей ContractWindow в объект---------------------
        private /*Dogovor*/ void GetDogov(/*Dogovor dogov*/)
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        dogov.IDClienta = CID;
        //        dogov.IDNedvigimosty = NID;
        //        dogov.WokerID = WID;
        //        long q = (from f in context.TypeDogovora where f.Name == tbTypeDogv.Text select f.IDTypeDogovora).FirstOrDefault();
        //        dogov.IDTypeDogovora = q;
        //        dogov.PriceNedvigimosty = Convert.ToInt32(tbprice.Text);
        //        dogov.DateRecord = tbDareRecord.Text;
        //        return dogov;

        //    }
        }
        ////-----------------Кнопка сохранить ContractWindow---------------------
        private void btsave_Click(object sender, RoutedEventArgs e)
        {
        //    using (AgencyDbEntities context = new AgencyDbEntities())
        //    {
        //        if (CNed.IDNedvigimosti == 0)
        //        {
        //            var nedv = new Nedvigimost();
        //            GetNedvigimost(nedv);
        //            List<Nedvigimost> listned = context.Nedvigimost.ToList();
        //            ImageCopy(nedv);
        //            context.Nedvigimost.Add(nedv);                  
        //            context.SaveChanges();
        //            var nedvList = new List<Nedvigimost>();
        //            nedvList = context.Nedvigimost.ToList();
        //            NID = (int)nedvList[nedvList.Count() - 1].IDNedvigimosti;
        //        }
        //        else { var NedvList = context.Nedvigimost.ToList();
        //            Nedvigimost Nedv = (from r in NedvList where (int)CNed.IDNedvigimosti == r.IDNedvigimosti select r).FirstOrDefault();
        //            GetNedvigimost(Nedv);
        //            context.SaveChanges();
        //            NID = (int)CNed.IDNedvigimosti;
        //            };

        //        if (cCln.ClientID == 0)
        //        {
        //            var client = new Client();
        //            GetCln(client);
        //            List<Client> listCln = context.Client.ToList();
        //            context.Client.Add(client);
        //            context.SaveChanges();
        //            var ClnList = new List<Client>();
        //            ClnList = context.Client.ToList();
        //            CID = (int)ClnList[ClnList.Count() - 1].ClientID;
        //        }
        //        else { CID = (int)cCln.ClientID; };
        //        var dogov = new Dogovor();
        //        GetDogov(dogov);
        //        context.Dogovor.Add(dogov);
        //        context.SaveChanges();
        //        MessageBox.Show("ContractWindow успешно заключен");
        //    }

        }
        ////-----------------Кнопка назад---------------------
        private void btBack_Click(object sender, RoutedEventArgs e)
        {
        //    MainWindow w3 = new MainWindow(Acs, WID);
        //    w3.Show();
        //    this.Close();
        }

     

       
    }
}

