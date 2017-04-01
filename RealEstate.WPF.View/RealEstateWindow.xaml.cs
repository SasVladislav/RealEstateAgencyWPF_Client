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
    /// Логика взаимодействия для RealEstateWindow.xaml
    /// </summary>
    public partial class RealEstateWindow : Window
    {
        
        //public int key = 0;
        //int id = 0;
        //private RealEstate.WPF.View.AgencyDbEntities context;
        //private Client cCln = new Client();
        //private Nedvigimost CNed = new Nedvigimost();
        //private int WID=0;
        //private int Acs=0;
        //public List<Nedvigimost> listned = new List<Nedvigimost>();
        //private TypeNedvigimosti currentNedv = new TypeNedvigimosti();
        //private State currentState = new State();
        //private TypeWall currentWall = new TypeWall();
        //private ClassNedvigimosti currentClass = new ClassNedvigimosti();
        //private Nedvigimost currentHome = new Nedvigimost();
        public RealEstateWindow(/*int Access, int Workerid,Client currCLN, Nedvigimost currNed*/)
        {
            InitializeComponent();            
            //CNed = currNed;
            //cCln = currCLN;           
            //WID = Workerid;
            //Acs = Access;
            //context = new RealEstate.WPF.View.AgencyDbEntities();
            //listned = (from t in context.Nedvigimost.ToList() where t.idStateNedvigimosti == 1 select t).ToList();
            //Fill();
            //nedvigimostDataGrid.ItemsSource = listned;
            //nedvigimostDataGrid.SelectedIndex = 0;               
        }
        //------------------загрузка формы----------------------------------
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
       // btChagennedv.Visibility = Visibility.Visible;
       // btSaveChange.Visibility = Visibility.Hidden;
       // Dostup();
        }

       // //-------------------------Свойство перехода по DataGrid---------------------------------
        private void nedvigimostDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {                       
       // if (nedvigimostDataGrid.SelectedIndex >=0)
       // {
       //     Dostup(); 
       // long a = ((Nedvigimost)nedvigimostDataGrid.SelectedItem).IDNedvigimosti;
       // FillNedv(a); ChangePost(a); CNed.IDNedvigimosti = (int)a; id = (int)a;
       // }
       // else{
       // nedvigimostDataGrid.SelectedIndex = 0;
        //}
        }

       // //-------------------Метод заполнения TextBox---------------------------
        private void FillNedv(long a)
        {           
       //     var nedv = (from t in listned where t.IDNedvigimosti == a select t);
       //     foreach (var v in nedv)
       //     {
       //         tbprice.Text = v.Price.ToString();//заполняем текстбоксы информацией из БД
       //         tbnumberOfRooms.Text = v.NumberOfRooms.ToString();
       //         levelTextBox.Text = v.Level.ToString();
       //         tbgrossArea.Text = v.GrossArea.ToString();
       //         tbnearSusway.Text = v.NearSusway;
       //         if (v.Lift == 1)
       //             cblift.IsChecked = true;
       //             else {cblift.IsChecked = false;}
       //         tbcity.Text = v.City;
       //         tbregion.Text = v.Region;
       //         tbstreet.Text = v.Street;
       //         tbhomeNomber.Text = v.HomeNomber.ToString();
       //         tbapartmentNomber.Text = v.ApartmentNomber.ToString();
       //     }                      
        }
       // //-------------------Метод заполнения ComboBox---------------------------
        private void ChangePost(long a)
        {
            
       //         currentNedv = (TypeNedvigimosti)((from t in context.Nedvigimost where t.IDNedvigimosti == a select t.TypeNedvigimosti).FirstOrDefault());
       //         cbTypeN.Text = currentNedv.Name;

       //         currentState = (State)((from s in context.Nedvigimost where s.IDNedvigimosti == a select s.State).FirstOrDefault());
       //         cbState.Text = currentState.Name;

       //         currentWall = (TypeWall)((from w in context.Nedvigimost where w.IDNedvigimosti == a select w.TypeWall).FirstOrDefault());
       //         cbTypeW.Text = currentWall.Name;

       //         currentClass = (ClassNedvigimosti)((from c in context.Nedvigimost where c.IDNedvigimosti == a select c.ClassNedvigimosti).FirstOrDefault());
       //         cbClass.Text = currentClass.Name;
       //         //-------------------Загрузка картинки---------------------------
       //         if (((Nedvigimost)nedvigimostDataGrid.SelectedItem).image == "")
       //             { Image.Source = null; return; }
       //         else 
       //         try
       //         { Image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory.ToString() + ((Nedvigimost)nedvigimostDataGrid.SelectedItem).image)); }
       //         catch (Exception ex)
       //             { MessageBox.Show(ex.Message + "+"); }
            }
       // //-------------------Кнопка назад ---------------------------
        private void btbackkPage_Click(object sender, RoutedEventArgs e)
        {
       //     {
       //         MainWindow w = new MainWindow(Acs, WID);
       //         w.Show();
       //         this.Close();
       //     }
        }
       // //-------------------Кнопка перехода по записям ->назад ---------------------------
        private void btBack_Click(object sender, RoutedEventArgs e)
        {                           
       //         if (nedvigimostDataGrid.SelectedIndex - 1 <= 0)
       //             nedvigimostDataGrid.SelectedIndex = 0;
       //         else
       //             nedvigimostDataGrid.SelectedIndex--;                         
        }
       // //-------------------Кнопка перехода по записям ->вперед ---------------------------
        private void btNext_Click(object sender, RoutedEventArgs e)
        {                           
       //         if (nedvigimostDataGrid.SelectedIndex + 1 >= listned.Count) 
       //             nedvigimostDataGrid.SelectedIndex = listned.Count - 1;
       //         else
       //             nedvigimostDataGrid.SelectedIndex++;                           
        }
       // //-----------------Запись с полей Недвижимости в объект---------------------
       private /*Nedvigimost*/void GetNedvigimost(/*Nedvigimost nedv*/)
       {
       //    TypeNedvigimosti q = (from f in context.TypeNedvigimosti where f.Name == cbTypeN.Text select f).FirstOrDefault();
       //    State w = (from f in context.State where f.Name == cbState.Text select f).FirstOrDefault();
       //    TypeWall e = (from f in context.TypeWall where f.Name == cbTypeW.Text select f).FirstOrDefault();
       //    ClassNedvigimosti r = (from f in context.ClassNedvigimosti where f.Name == cbClass.Text select f).FirstOrDefault();
       //        nedv.idTypeNedvigimosti= q.idTypeNedvigimosti;        
       //        nedv.idStateNedvigimosti = w.idState;
       //        nedv.idTypeWall = e.idTypeWall;
       //        nedv.idClassHome = r.idClassNedvigimosti;
       //        nedv.Price = Convert.ToInt32(tbprice.Text);
       //        nedv.NumberOfRooms = Convert.ToInt32(tbnumberOfRooms.Text);
       //        nedv.Level = Convert.ToInt32(levelTextBox.Text);
       //        nedv.GrossArea = Convert.ToInt32(tbgrossArea.Text);
       //        nedv.NearSusway = tbnearSusway.Text;
       //        if (cblift.IsChecked == true)
       //            nedv.Lift = 1;
       //        else { nedv.Lift = 0; }   
       //        nedv.City = tbcity.Text;
       //        nedv.Region = tbregion.Text;
       //        nedv.Street = tbstreet.Text;
       //        nedv.HomeNomber = Convert.ToInt32(tbhomeNomber.Text);
       //        nedv.ApartmentNomber = Convert.ToInt32(tbapartmentNomber.Text);
       //        nedv.image = Image.Source.ToString();
       //    return nedv;
       }
       // //----------------------Кнопка сохранить----------------------
       private void btSaveChange_Click(object sender, RoutedEventArgs e)
       {
       //    Nedvigimost Nedv = (from r in context.Nedvigimost where id == r.IDNedvigimosti select r).FirstOrDefault();
       //    GetNedvigimost(Nedv);
       //    ImageCopy(Nedv);
       //    context.SaveChanges();
       //    MessageBox.Show("Изменения сохранены");
       //    nedvigimostDataGrid.ItemsSource = (from t in context.Nedvigimost.ToList() where t.idStateNedvigimosti == 1 select t);
       //    Dostup();
       //    btChagennedv.Visibility = Visibility.Visible;
       //    btSaveChange.Visibility = Visibility.Hidden;
       }
       ////---------------------- Кнопка Изменение недвижимости----------------------
       private void btChagennedv_Click(object sender, RoutedEventArgs e)
       {
       //    btChagennedv.Visibility = Visibility.Hidden;
       //    btSaveChange.Visibility = Visibility.Visible;
       //    ChangeDostup();
       }
       ////---------------------- Заполнение CоmboBox содержимым----------------------
        private void Fill()
        {
            
       //         var TypeN = from t in context.TypeNedvigimosti select t;
       //         var Wall = from w in context.TypeWall select w;
       //         var State = from s in context.State select s;
       //         var Class = from c in context.ClassNedvigimosti select c;
       //         var level = from l in context.Nedvigimost select l;
       //         var distinctCity = (from m in context.Nedvigimost select m.City).Distinct();
       //         var distinctRegion = (from m in context.Nedvigimost select m.Region).Distinct();
       //         var distinctStreet = (from m in context.Nedvigimost select m.Street).Distinct();
       //         foreach (var dc in distinctCity) { cbFiltCity.Items.Add(dc); }
       //         foreach (var dr in distinctRegion) { cbFiltRayon.Items.Add(dr); }
       //         foreach (var ds in distinctStreet) { cbFiltStreet.Items.Add(ds); }
       //         foreach (TypeNedvigimosti Typel in TypeN) { cbTypeN.Items.Add(Typel.Name); cbFiltType.Items.Add(Typel.Name); }
       //         foreach (TypeWall TypeW in Wall) { cbTypeW.Items.Add(TypeW.Name); cbFiltW.Items.Add(TypeW.Name); }
       //         foreach (State St in State) { cbState.Items.Add(St.Name); }
       //         foreach (ClassNedvigimosti Cl in Class) { cbClass.Items.Add(Cl.Name); cbFiltClass.Items.Add(Cl.Name); }
       //         //foreach (Nedvigimost N in level) { cbFiltCity.Items.Add(N.City); cbFiltRayon.Items.Add(N.Region); cbFiltStreet.Items.Add(N.Street);
                
       //     //}
        }
       // //---------------------- Чек бокс Доступ к проданной недвижимости----------------------                     
          private void chbDostup_Click(object sender, RoutedEventArgs e)
       {
       //     if (chbDostup.IsChecked == true)
       //     { key = 1; listned = (from t in context.Nedvigimost.ToList() where t.idStateNedvigimosti == 2 select t).ToList(); nedvigimostDataGrid.ItemsSource = listned; btChagennedv.Visibility = Visibility.Hidden; btSaveChange.Visibility = Visibility.Hidden; btdogNedv.Visibility = Visibility.Hidden; }
       //     else { key = 0; listned = (from t in context.Nedvigimost.ToList() where t.idStateNedvigimosti == 1 select t).ToList(); nedvigimostDataGrid.ItemsSource = listned; btChagennedv.Visibility = Visibility.Visible; btSaveChange.Visibility = Visibility.Visible; btdogNedv.Visibility = Visibility.Visible; }
        }
       //   //---------------------- Фильтры недвижимости----------------------
          private void Fillnedv()
          {
       //       if (key == 1)
       //       { listned = (from t in context.Nedvigimost.ToList() where t.idStateNedvigimosti == 2 select t).ToList();
       //          }
       //       else
       //       { listned = (from t in context.Nedvigimost.ToList() where t.idStateNedvigimosti == 1 select t).ToList();
       //           }
       //       nedvigimostDataGrid.ItemsSource = listned;
       //               if (cbFiltW.SelectedValue != null)
       //               { var o = (from f in context.TypeWall where f.Name == (string)cbFiltW.SelectedValue select f);
       //                   foreach (var n in o)
       //                   { var v = (from l in listned where l.idTypeWall == n.idTypeWall select l);
       //                       if (v.Count() != 0)
       //                         { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                         else{ nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //                   } }
       //               if (cbFiltType.SelectedValue != null)
       //               { var a = (from f in context.TypeNedvigimosti where f.Name == (string)cbFiltType.SelectedValue select f);
       //                   foreach (var n in a)
       //                   { var v = (from l in listned where l.idTypeNedvigimosti == n.idTypeNedvigimosti select l);
       //                       if (v.Count() != 0)
       //                         { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                       else { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //                   }}
       //               if (cbFiltClass.SelectedValue != null)
       //               { var a = (from f in context.ClassNedvigimosti where f.Name == (string)cbFiltClass.SelectedValue select f);
       //                   foreach (var n in a)
       //                   { var v = (from l in listned where l.idClassHome == n.idClassNedvigimosti select l);
       //                       if (v.Count() != 0)
       //                         { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                         else { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //                   }}
       //               if (cbFiltCity.SelectedValue != null)
       //               { var v = (from l in listned where l.City == (string)cbFiltCity.SelectedValue select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else {nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //               }
       //               if (cbFiltRayon.SelectedValue != null)
       //               { var v = (from l in listned where l.Region == (string)cbFiltRayon.SelectedValue select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else
       //                   { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных");}
       //               }
       //               if (cbFiltStreet.SelectedValue != null)
       //               { var v = (from l in listned where l.Street == (string)cbFiltStreet.SelectedValue select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else
       //                   { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных");}
       //               }
       //               if (tbFiltAreaot.Text != "")
       //               {
       //                   var v = (from l in listned where l.GrossArea >= Convert.ToDouble(tbFiltAreaot.Text) select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else
       //                   { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //               }
       //               if (tbFiltAreado.Text != "")
       //               {
       //                   var v = (from l in listned where l.GrossArea <= Convert.ToDouble(tbFiltAreado.Text) select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else
       //                   { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //               }
       //               if (tbFiltPriceot.Text != "")
       //               {
       //                   var v = (from l in listned where l.Price >= Convert.ToDouble(tbFiltPriceot.Text) select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else
       //                   { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //               }
       //               if (tbFiltPricedo.Text != "")
       //               {
       //                   var v = (from l in listned where l.Price <= Convert.ToDouble(tbFiltPricedo.Text) select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else
       //                   { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //               }
       //               if (tbFiltLevelot.Text != "")
       //               {
       //                   var v = (from l in listned where l.Level >= Convert.ToDouble(tbFiltLevelot.Text) select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else
       //                   { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //               }
       //               if (tbFiltLeveldo.Text != "")
       //               {
       //                   var v = (from l in listned where l.Level <= Convert.ToDouble(tbFiltLeveldo.Text) select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else
       //                   { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //               }
       //               if (tbFiltFlatot.Text != "")
       //               {
       //                   var v = (from l in listned where l.NumberOfRooms >= Convert.ToDouble(tbFiltFlatot.Text) select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else
       //                   { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //               }
       //               if (tbFiltFlado.Text != "")
       //               {
       //                   var v = (from l in listned where l.NumberOfRooms <= Convert.ToDouble(tbFiltFlado.Text) select l);
       //                   if (v.Count() != 0)
       //                   { nedvigimostDataGrid.ItemsSource = v; listned = v.ToList(); }
       //                   else
       //                   { nedvigimostDataGrid.ItemsSource = v; MessageBox.Show("Недвижимости с данным параметром нет в базе данных"); }
       //               }
              }

          private void ChangeDostup() 
          {
       //       cbTypeN.IsEnabled = true; 
       //       cbState.IsEnabled = true;
       //       cbTypeW.IsEnabled = true;
       //       cbClass.IsEnabled = true;
       //       tbprice.IsReadOnly = false;
       //       tbnumberOfRooms.IsReadOnly = false;
       //       levelTextBox.IsReadOnly = false;
       //       tbgrossArea.IsReadOnly = false;
       //       tbnearSusway.IsReadOnly = false;
       //       /*if (v.Lift == 1)
       //           cblift.IsChecked = true;
       //       else { cblift.IsChecked = false; }*/
       //       tbcity.IsReadOnly = false;
       //       tbregion.IsReadOnly = false;
       //       tbstreet.IsReadOnly = false;
       //       tbhomeNomber.IsReadOnly = false;
       //       tbapartmentNomber.IsReadOnly = false;
       //       btnBrowse.Visibility = Visibility.Visible;
          }


          private void Dostup() 
          {
       //       cbTypeN.IsEnabled = false;
       //       cbState.IsEnabled = false;
       //       cbTypeW.IsEnabled = false;
       //       cbClass.IsEnabled = false;
       //       tbprice.IsReadOnly = true;
       //       tbnumberOfRooms.IsReadOnly = true;
       //       levelTextBox.IsReadOnly = true;
       //       tbgrossArea.IsReadOnly = true;
       //       tbnearSusway.IsReadOnly = true;
       //       /*if (v.Lift == 1)
       //           cblift.IsChecked = true;
       //       else { cblift.IsChecked = false; }*/
       //       tbcity.IsReadOnly = true;
       //       tbregion.IsReadOnly = true;
       //       tbstreet.IsReadOnly = true;
       //       tbhomeNomber.IsReadOnly = true;
       //       tbapartmentNomber.IsReadOnly = true;
       //       btnBrowse.Visibility = Visibility.Hidden;
          }
       //   //---------------------- Кнопка выбрать недвижимость----------------------
          private void btdogNedv_Click(object sender, RoutedEventArgs e)
          {
       //       GetNedvigimost(CNed);
       //       ContractWindow dogov = new ContractWindow( Acs, WID, cCln, CNed,0);
       //       dogov.Show();
       //       this.Close();
          }

        private void btClearFilt_Click(object sender, RoutedEventArgs e)
        {
            
       //     cbFiltClass.Text = "";
       //     cbFiltW.Text = "";
       //     cbFiltType.Text = "";
       //     tbFiltPriceot.Text = "";
       //     tbFiltPricedo.Text = "";
       //     cbFiltCity.Text = "";
       //     cbFiltRayon.Text = "";
       //     cbFiltStreet.Text = "";
        }        
        private void cbFiltCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       //     Fillnedv(); 
        }

        private void cbFiltClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void cbFiltW_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void cbFiltType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void cbFiltRayon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void cbFiltStreet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void tbFiltAreaot_TextChanged(object sender, TextChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void tbFiltAreado_TextChanged(object sender, TextChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void tbFiltPriceot_TextChanged(object sender, TextChangedEventArgs e)
        {
         //   Fillnedv();
        }

        private void tbFiltPricedo_TextChanged(object sender, TextChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void tbFiltLevelot_TextChanged(object sender, TextChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void tbFiltLeveldo_TextChanged(object sender, TextChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void tbFiltFlatot_TextChanged(object sender, TextChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void tbFiltFlado_TextChanged(object sender, TextChangedEventArgs e)
        {
       //     Fillnedv();
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
       //     using (AgencyDbEntities context = new AgencyDbEntities())
       //     {
       //         if (context.Nedvigimost.ToList().Count == 0)
       //             MessageBox.Show("There's no nedvigimost yet");
       //         else
       //         {
       //             OpenFileDialog dialog = new OpenFileDialog();
       //             dialog.Filter = "Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
       //             Nullable<bool> result = dialog.ShowDialog();
       //             if (result == true)
       //             {
       //                 try
       //                 {
       //                     Image.Source = new BitmapImage(new Uri(dialog.FileName));
       //                 }
       //                 catch (Exception ex)
       //                 {
       //                     MessageBox.Show(ex.Message);
       //                 }
       //             }
       //         }
       //     }
        }
       
        private void ImageCopy(/*Nedvigimost ned*/)
        {
       //     string path = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\Images";
       //     if (!Directory.Exists(path))
       //     {
       //         Directory.CreateDirectory(path);
       //     }
           
       //     if (Image.Source.ToString() == ned.image)
       //     {  }
       //     else{
       //     if (Image.Source != null)
       //     {
       //         string localFilePath = new Uri(Image.Source.ToString()).LocalPath;
       //         File.Copy(localFilePath,
       //         AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\Images\" +
       //         System.IO.Path.GetFileName(localFilePath), true);
       //         ned.image =  @"\Images\" +
       //         System.IO.Path.GetFileName(localFilePath);
                
       //     }
       //     }
        }
    }
}
