using NewsApp.Models;

namespace NewsApp.Pages;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(Article article)
	{
		InitializeComponent();
		ImgNews.Source = article.Image;
        LBlTitle.Text = article.Title;
		LblContant.Text = article.Content;

    }
}