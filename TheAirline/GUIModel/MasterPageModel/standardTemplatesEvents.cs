﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using TheAirline.GraphicsModel.PageModel.GeneralModel;
using TheAirline.GraphicsModel.PageModel.PageAirportModel;
using TheAirline.GUIModel.PagesModel.AirlinePageModel;
using TheAirline.Model.AirlineModel;
using TheAirline.Model.AirportModel;

namespace TheAirline.GUIModel.MasterPageModel
{
    public partial class standardTemplatesEvents
    {
        private void Airport_Click(object sender, RoutedEventArgs e)
        {
            Airport airport = (Airport)((Hyperlink)sender).Tag;
            PageNavigator.NavigateTo(new GUIModel.PagesModel.AirportPageModel.PageAirport(airport));
        }
        private void Alliance_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Airline_Click(object sender, RoutedEventArgs e)
        {
            Airline airline = (Airline)((Hyperlink)sender).Tag;
            PageNavigator.NavigateTo(new PageAirline(airline));
        }
    }
}
