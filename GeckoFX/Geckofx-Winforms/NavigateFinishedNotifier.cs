﻿using System;
using System.Windows.Forms;

namespace Gecko
{
    /// <summary>
    /// Use the DocumentCompleted event instead of the NavigateFinished event.
    /// </summary>
    public class NavigateFinishedNotifier : IDisposable
    {
        GeckoWebBrowser m_browser;

        public NavigateFinishedNotifier(GeckoWebBrowser browser)
        {
            m_browser = browser;
        }

        /// <summary>
        /// This method is only intended to be used by unittests
        /// The normal way to know when a document has finished loading is to listen for the DocumentCompleted event.
        /// </summary>
        public void BlockUntilNavigationFinished()
        {
            bool done = false;
            m_browser.DocumentCompleted += (sender, e) => done = true;
            m_browser.NavigationError += (sender, e) => done = true;
            m_browser.Retargeted += (sender, e) => done = true;
            while (!done)
            {
                Application.DoEvents();
                Application.RaiseIdle(new EventArgs());
            }
        }

        public event EventHandler NavigateFinished;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
