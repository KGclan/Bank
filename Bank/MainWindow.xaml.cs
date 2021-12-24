using System.Windows;
using Bank.models;

namespace Bank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void initdb()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем три объекта Aggrements
                Aggrement agr1 = new Aggrement { Number = 1, DataOpen = "1.1.22", DataClose = "10.10.22", Note = "GGWP" };
                db.Aggrements.Add(agr1);
                Aggrement agr2 = new Aggrement { Number = 2, DataOpen = "2.2.22", DataClose = "11.11.22", Note = "GGWP" };
                db.Aggrements.Add(agr2);
                Aggrement agr3 = new Aggrement { Number = 3, DataOpen = "3.3.22", DataClose = "12.12.22", Note = "GGWP" };
                db.Aggrements.Add(agr3);
                db.SaveChanges();
                // создаем три объекта TypeAccount
                TypeAccount typeAcc1 = new TypeAccount { AccountType = "Инвестиционный" };
                db.TypeAccounts.Add(typeAcc1);
                TypeAccount typeAcc2 = new TypeAccount { AccountType = "Накопительный" };
                db.TypeAccounts.Add(typeAcc2);
                TypeAccount typeAcc3 = new TypeAccount { AccountType = "Кредитный" };
                db.TypeAccounts.Add(typeAcc3);
                db.SaveChanges();
                // создаем три объекта Bank
                Banks bank1 = new Banks { NameFull = "Банк № 1", NameShort = "Б1", Inn = 1, Bik = 1, CorAccount = 1, Account = 1, City = "Город 1" };
                db.Banks.Add(bank1);
                Banks bank2 = new Banks { NameFull = "Банк № 2", NameShort = "Б2", Inn = 2, Bik = 2, CorAccount = 2, Account = 2, City = "Город 2" };
                db.Banks.Add(bank2);
                Banks bank3 = new Banks { NameFull = "Банк № 3", NameShort = "Б3", Inn = 3, Bik = 3, CorAccount = 3, Account = 3, City = "Город 3" };
                db.Banks.Add(bank3);
                db.SaveChanges();
                // создаем три объекта Account
                Account acc1 = new Account { BankID = bank1.ID, AggrementID = agr1.ID, TypeID = typeAcc1.ID, AccountNumber = 1 };
                db.Accounts.Add(acc1);
                Account acc2 = new Account { BankID = bank2.ID, AggrementID = agr2.ID, TypeID = typeAcc2.ID, AccountNumber = 2 };
                db.Accounts.Add(acc2);
                Account acc3 = new Account { BankID = bank3.ID, AggrementID = agr3.ID, TypeID = typeAcc3.ID, AccountNumber = 3 };
                db.Accounts.Add(acc3);
                db.SaveChanges();
            }
        }
        public void button_Click(object sender, RoutedEventArgs e)
        {
            initdb();
            textBlock.Text = "База данных создана. Объекты успешно сохранены. ";
        }
    }
}
