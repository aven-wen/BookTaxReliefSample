using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;

using BookTaxRelief;

namespace BookTaxReliefSample
{
    public partial class formMain : Form
    {
        // EAN: 8667106506069
        private readonly string appId = ConfigurationManager.AppSettings["App_Id"];
        private readonly string appURI = ConfigurationManager.AppSettings["App_URI"];

        public formMain() => InitializeComponent();

        private void btnGetPolicyExpiryDate_Click(object sender, EventArgs e)
        {
            try
            {
                using (TaxReliefClient reliefClient = new TaxReliefClient(appId: appId))
                    txtResult.Text = (reliefClient.GetExpiryDate()).ToString("yyyy/MM/dd");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnGetDaily_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DateTime.TryParseExact(txtParameter.Text, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime dateValue)) throw new Exception("日期格式錯誤!");

                using (TaxReliefClient reliefClient = new TaxReliefClient(uri: appURI, appId: appId))
                {
                    DailyResponse response = reliefClient.GetDaily(txtParameter.Text);
                    string resultMessage = $"{txtParameter.Text}認可公告(ISBN)\r\n=======================================================\r\n";
                    foreach (IsbnObject isbn in response.approved.isbns)
                        resultMessage += $"{IsbnMessage(isbn)}\r\n-------------------------------------------------------\r\n";
                    resultMessage += $"{txtParameter.Text}認可公告(EAN)\r\n=======================================================\r\n";
                    foreach (EanObject ean in response.approved.eans)
                        resultMessage += $"{EanMessage(ean)}\r\n" +
                            "-------------------------------------------------------\r\n";

                    resultMessage += $"{txtParameter.Text}撤銷公告(ISBN)\r\n=======================================================\r\n";
                    foreach (IsbnObject isbn in response.revoked.isbns)
                        resultMessage += $"{IsbnMessage(isbn)}\r\n-------------------------------------------------------\r\n";
                    resultMessage += $"{txtParameter.Text}撤銷公告(EAN)\r\n=======================================================\r\n";
                    foreach (EanObject ean in response.revoked.eans)
                        resultMessage += $"{EanMessage(ean)}\r\n" +
                            "-------------------------------------------------------\r\n";

                    resultMessage += $"{txtParameter.Text}異動公告(ISBN)\r\n=======================================================\r\n";
                    foreach (IsbnObject isbn in response.changed.isbns)
                        resultMessage += $"{IsbnMessage(isbn)}\r\n-------------------------------------------------------\r\n";
                    resultMessage += $"{txtParameter.Text}異動公告(EAN)\r\n=======================================================\r\n";
                    foreach (EanObject ean in response.changed.eans)
                        resultMessage += $"{EanMessage(ean)}\r\n" +
                            "-------------------------------------------------------\r\n";

                    txtResult.Text = resultMessage;

                    MessageBox.Show("Success!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            try
            {
                using (TaxReliefClient reliefClient = new TaxReliefClient(uri: appURI, appId: appId))
                {
                    DailyResponse response = reliefClient.GetToday();
                    string resultMessage = $"{DateTime.Today:yyyy/MM/dd}認可公告(ISBN)\r\n=======================================================\r\n";
                    foreach (IsbnObject isbn in response.approved.isbns)
                        resultMessage += $"{IsbnMessage(isbn)}\r\n-------------------------------------------------------\r\n";
                    resultMessage += $"{DateTime.Today:yyyy/MM/dd}認可公告(EAN)\r\n=======================================================\r\n";
                    foreach (EanObject ean in response.approved.eans)
                        resultMessage += $"{EanMessage(ean)}\r\n" +
                            "-------------------------------------------------------\r\n";

                    resultMessage += $"{DateTime.Today:yyyy/MM/dd}撤銷公告(ISBN)\r\n=======================================================\r\n";
                    foreach (IsbnObject isbn in response.revoked.isbns)
                        resultMessage += $"{IsbnMessage(isbn)}\r\n-------------------------------------------------------\r\n";
                    resultMessage += $"{DateTime.Today:yyyy/MM/dd}撤銷公告(EAN)\r\n=======================================================\r\n";
                    foreach (EanObject ean in response.revoked.eans)
                        resultMessage += $"{EanMessage(ean)}\r\n" +
                            "-------------------------------------------------------\r\n";

                    resultMessage += $"{DateTime.Today:yyyy/MM/dd}異動公告(ISBN)\r\n=======================================================\r\n";
                    foreach (IsbnObject isbn in response.changed.isbns)
                        resultMessage += $"{IsbnMessage(isbn)}\r\n-------------------------------------------------------\r\n";
                    resultMessage += $"{DateTime.Today:yyyy/MM/dd}異動公告(EAN)\r\n=======================================================\r\n";
                    foreach (EanObject ean in response.changed.eans)
                        resultMessage += $"{EanMessage(ean)}\r\n" +
                            "-------------------------------------------------------\r\n";

                    txtResult.Text = resultMessage;

                    MessageBox.Show("Success!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnGetIsbn_Click(object sender, EventArgs e)
        {
            try
            {
                using (TaxReliefClient reliefClient = new TaxReliefClient(appId: appId))
                    txtResult.Text = $"==================== 書籍資訊 ====================\r\n{IsbnMessage(reliefClient.GetIsbn(txtParameter.Text))}\r\n";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnMultiIsbn_Click(object sender, EventArgs e)
        {
            try
            {
                using (TaxReliefClient reliefClient = new TaxReliefClient(appId: appId))
                {

                    List<IsbnObject> isbns = reliefClient.GetMultiIsbn(txtParameter.Text);
                    string resultMessage = $"ISBN認可公告\r\n=======================================================\r\n";
                    foreach (IsbnObject isbn in isbns)
                        resultMessage += $"{IsbnMessage(isbn)}\r\n";

                    txtResult.Text = resultMessage;

                    MessageBox.Show("Success!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnGetEan_Click(object sender, EventArgs e)
        {
            try
            {
                using (TaxReliefClient reliefClient = new TaxReliefClient(appId: appId))
                    txtResult.Text = EanMessage(reliefClient.GetEan(txtParameter.Text));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnMultiEan_Click(object sender, EventArgs e)
        {
            try
            {
                using (TaxReliefClient reliefClient = new TaxReliefClient(appId: appId))
                {
                    List<EanObject> eans = reliefClient.GetMultiEan(txtParameter.Text);
                    string resultMessage = $"EAN認可公告\r\n=======================================================\r\n";
                    foreach (EanObject ean in eans)
                        resultMessage += $"{EanMessage(ean)}\r\n";

                    txtResult.Text = resultMessage;

                    MessageBox.Show("Success!");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string IsbnMessage(IsbnObject isbn)
        {
            return $"ISBN: {isbn.isbn}\r\n" +
                    $"書名: {isbn.title}\r\n" +
                    $"10碼: {isbn.isbn_10}\r\n" +
                    $"13碼: {isbn.isbn_13}\r\n" +
                    $"認可生效日期: {isbn.approved_effective_date:yyyy/MM/dd}\r\n" +
                    $"撤銷生效日期: {isbn.revoked_effective_date:yyyy/MM/dd}\r\n" +
                    $"包含電子書: {(isbn.include_ebook ? "是" : "否")}\r\n" +
                    $"書籍類型: {isbn.kind}\r\n" +
                    $"出版者: {isbn.publisher}\r\n" +
                    $"類別: {isbn.type}\r\n" +
                    $"狀態: {IsbnStatus(isbn.status)}\r\n";
        }

        private string IsbnStatus(IsbnStatusEnum isbnStatus)
        {
            switch (isbnStatus)
            {
                case IsbnStatusEnum.applying: return "審核";
                case IsbnStatusEnum.approved: return "認可";
                case IsbnStatusEnum.expired: return "逾期";
                case IsbnStatusEnum.revoked: return "撤銷";
                default: return "";
            }
        }

        private string EanMessage(EanObject ean)
        {
            string resultMessage = "==================== EAN資訊 ====================\r\n" +
                        $"EAN: {ean.ean}\r\n" +
                        $"Title: {ean.title}\r\n" +
                        $"異動日期: {ean.last_modified:yyyy/MM/dd HH:mm:ss}\r\n" +
                        $"狀態: {EanStatus(ean.status)}\r\n";
            foreach (IsbnObject isbn in ean.isbns)
                resultMessage += $"-------------------------------------------------------\r\n{IsbnMessage(isbn)}";

            return resultMessage;
        }

        private string EanStatus(EanStatusEnum eanStatus)
        {
            switch (eanStatus)
            {
                case EanStatusEnum.enabled: return "開啟";
                case EanStatusEnum.disable: return "關閉";
                default: return "";
            }
        }
    }
}
