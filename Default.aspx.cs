using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ShowTrackerServiceReference1.ShowTrackerServiceClient bsc = new ShowTrackerServiceReference1.ShowTrackerServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillArtistDropDown();
            FillVenueDropDown();
            FillArtistsGrid();
            FillShowGrid();
            FillVenueGrid();
        }
    }

    protected void FillArtistDropDown()
    {
        string[] artists = bsc.GetArtists();
        DropDownList1.DataSource = artists;
        DropDownList1.DataBind();
    }

    protected void FillVenueDropDown()
    {
        string[] venues = bsc.GetVenues();
        DropDownList2.DataSource = venues;
        DropDownList2.DataBind();
    }

    protected void FillArtistsGrid()
    {
        string[] artists = bsc.GetArtists();
        GridViewArtists.DataSource = artists;
        GridViewArtists.DataBind();
    }
    protected void FillVenueGrid()
    {
        string[] venues = bsc.GetVenues();
        GridViewVenues.DataSource = venues;
        GridViewVenues.DataBind();
    }
    protected void FillShowGrid()
    {
        string[] shows = bsc.GetShows();
        GridViewShows.DataSource = shows;
        GridViewShows.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string artist = DropDownList1.SelectedItem.Text;
        ShowTrackerServiceReference1.ShowInfoArtist[] artists = bsc.GetShowInfoArtist(artist);
        GridView1.DataSource = artists;
        GridView1.DataBind();
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        string venue = DropDownList2.SelectedItem.Text;
        ShowTrackerServiceReference1.ShowInfoVenue[] venues = bsc.GetShowInfoVenue(venue);
        GridView2.DataSource = venues;
        GridView2.DataBind();
    }
}