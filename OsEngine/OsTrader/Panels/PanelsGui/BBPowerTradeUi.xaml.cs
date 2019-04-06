﻿/*
 * Your rights to use code governed by this license https://github.com/AlexWan/OsEngine/blob/master/LICENSE
 * Ваши права на использование кода регулируются данной лицензией http://o-s-a.net/doc/license_simple_engine.pdf
*/

using System;
using System.Globalization;
using System.Windows;
using OsEngine.Language;

namespace OsEngine.OsTrader.Panels.PanelsGui
{

    public partial class BbPowerTradeUi
    {
        private BbPowerTrade _strategy;
        public BbPowerTradeUi(BbPowerTrade strategy)
        {
            InitializeComponent();
            _strategy = strategy;

            TextBoxVolumeOne.Text = _strategy.VolumeFix.ToString();
            Step.Text = _strategy.Step.ToString();
            TextBoxSlipage.Text = _strategy.Slipage.ToString(new CultureInfo("ru-RU"));

            ComboBoxRegime.Items.Add(BotTradeRegime.Off);
            ComboBoxRegime.Items.Add(BotTradeRegime.On);
            ComboBoxRegime.Items.Add(BotTradeRegime.OnlyClosePosition);
            ComboBoxRegime.Items.Add(BotTradeRegime.OnlyLong);
            ComboBoxRegime.Items.Add(BotTradeRegime.OnlyShort);
            ComboBoxRegime.SelectedItem = _strategy.Regime;

            LabelRegime.Content = OsLocalization.Trader.Label115;
            LabelVolume.Content = OsLocalization.Trader.Label30;
            LabelSlippage.Content = OsLocalization.Trader.Label92;
            ButtonAccept.Content = OsLocalization.Trader.Label132;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(TextBoxVolumeOne.Text) <= 0 ||
                    Convert.ToDecimal(Step.Text) <= 0 ||
                    Convert.ToDecimal(TextBoxSlipage.Text) < 0)
                {
                    throw new Exception("");
                }
                Convert.ToDecimal(TextBoxSlipage.Text);
                Convert.ToDecimal(Step.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(OsLocalization.Trader.Label13);
                return;
            }

            _strategy.VolumeFix = Convert.ToDecimal(TextBoxVolumeOne.Text);
            _strategy.Slipage = Convert.ToDecimal(TextBoxSlipage.Text);
            _strategy.Step = Convert.ToDecimal(Step.Text);

            Enum.TryParse(ComboBoxRegime.Text, true, out _strategy.Regime);

            _strategy.Save();
            Close();
        }
    }
}

