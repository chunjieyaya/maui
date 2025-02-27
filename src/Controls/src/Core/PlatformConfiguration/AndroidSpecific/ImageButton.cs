﻿namespace Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific
{
	using Microsoft.Maui.Graphics;
	using FormsImageButton = Maui.Controls.ImageButton;

	/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="Type[@FullName='Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific.ImageButton']/Docs" />
	public static class ImageButton
	{
		#region Shadow
		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='IsShadowEnabledProperty']/Docs" />
		public static readonly BindableProperty IsShadowEnabledProperty = BindableProperty.Create("IsShadowEnabled", typeof(bool), typeof(Maui.Controls.ImageButton), false);

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='GetIsShadowEnabled'][0]/Docs" />
		public static bool GetIsShadowEnabled(BindableObject element)
		{
			return (bool)element.GetValue(IsShadowEnabledProperty);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='SetIsShadowEnabled'][0]/Docs" />
		public static void SetIsShadowEnabled(BindableObject element, bool value)
		{
			element.SetValue(IsShadowEnabledProperty, value);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='GetIsShadowEnabled']/Docs" />
		public static bool GetIsShadowEnabled(this IPlatformElementConfiguration<Android, FormsImageButton> config)
		{
			return GetIsShadowEnabled(config.Element);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='SetIsShadowEnabled']/Docs" />
		public static IPlatformElementConfiguration<Android, FormsImageButton> SetIsShadowEnabled(this IPlatformElementConfiguration<Android, FormsImageButton> config, bool value)
		{
			SetIsShadowEnabled(config.Element, value);
			return config;
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='ShadowColorProperty']/Docs" />
		public static readonly BindableProperty ShadowColorProperty = BindableProperty.Create("ShadowColor", typeof(Color), typeof(ImageButton), null);

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='GetShadowColor'][0]/Docs" />
		public static Color GetShadowColor(BindableObject element)
		{
			return (Color)element.GetValue(ShadowColorProperty);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='SetShadowColor'][0]/Docs" />
		public static void SetShadowColor(BindableObject element, Color value)
		{
			element.SetValue(ShadowColorProperty, value);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='GetShadowColor']/Docs" />
		public static Color GetShadowColor(this IPlatformElementConfiguration<Android, FormsImageButton> config)
		{
			return GetShadowColor(config.Element);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='SetShadowColor']/Docs" />
		public static IPlatformElementConfiguration<Android, FormsImageButton> SetShadowColor(this IPlatformElementConfiguration<Android, FormsImageButton> config, Color value)
		{
			SetShadowColor(config.Element, value);
			return config;
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='ShadowRadiusProperty']/Docs" />
		public static readonly BindableProperty ShadowRadiusProperty = BindableProperty.Create("ShadowRadius", typeof(double), typeof(ImageButton), 10.0);

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='GetShadowRadius'][0]/Docs" />
		public static double GetShadowRadius(BindableObject element)
		{
			return (double)element.GetValue(ShadowRadiusProperty);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='SetShadowRadius'][0]/Docs" />
		public static void SetShadowRadius(BindableObject element, double value)
		{
			element.SetValue(ShadowRadiusProperty, value);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='GetShadowRadius']/Docs" />
		public static double GetShadowRadius(this IPlatformElementConfiguration<Android, FormsImageButton> config)
		{
			return GetShadowRadius(config.Element);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='SetShadowRadius']/Docs" />
		public static IPlatformElementConfiguration<Android, FormsImageButton> SetShadowRadius(this IPlatformElementConfiguration<Android, FormsImageButton> config, double value)
		{
			SetShadowRadius(config.Element, value);
			return config;
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='ShadowOffsetProperty']/Docs" />
		public static readonly BindableProperty ShadowOffsetProperty = BindableProperty.Create("ShadowOffset", typeof(Size), typeof(VisualElement), Size.Zero);

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='GetShadowOffset'][0]/Docs" />
		public static Size GetShadowOffset(BindableObject element)
		{
			return (Size)element.GetValue(ShadowOffsetProperty);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='SetShadowOffset'][0]/Docs" />
		public static void SetShadowOffset(BindableObject element, Size value)
		{
			element.SetValue(ShadowOffsetProperty, value);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='GetShadowOffset']/Docs" />
		public static Size GetShadowOffset(this IPlatformElementConfiguration<Android, FormsImageButton> config)
		{
			return GetShadowOffset(config.Element);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific/ImageButton.xml" path="//Member[@MemberName='SetShadowOffset']/Docs" />
		public static IPlatformElementConfiguration<Android, FormsImageButton> SetShadowOffset(this IPlatformElementConfiguration<Android, FormsImageButton> config, Size value)
		{
			SetShadowOffset(config.Element, value);
			return config;
		}
		#endregion
	}
}
