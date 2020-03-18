csproj eke thama nuget package eke ewwa vatenne
--------------------------------------------------
properties wala launchSetting
	*mekedi thamai run venna one button eka ebuwama wada karanne komada kiyala tinne
---------------------------------------------------
WWWROOT
	*meke thamai static hama ekakma tinne.code ekakwath mekata danne naha.
---------------------------------------------------
PAGES
	*meke thama pages tika tinne.shared eke tinne reuse karanna kiyala ganna evva.

	_viewimports- meke tinne taghelpers apita pages walata danna puluwan naththam globally 
		meke add karanna puluwan.cs code naha meke.
	
	_viewStart- meke thamai patan ganna page eka tinne
-----------------------------------------------------
ROUTING
	www.domain.com-  		/Pages/Index.cshtml
	www.domain.com/index-  		/Pages/Index.cshtml
	www.domain.com/account-		/Pages/account/index.cshtml
	www.domain.com/pamal/privacy-   /Pages/pamal/privacy.cshtml(pamal kiyanne folder eka)
------------------------------------------------------
ASP .NETCORE PIPELINE
	*mekedi web server ekata req eka enawa browser eken then invoked dotnet runtime itapasse 
	 balanawa meke entry point eka eken start karanawa internal web server eka.Kestrel thama 
	 tinne (request routed from IIS to kestrel then kestrel to application then process in the 
	 middlewares and generated response routed to kestrel which route back to IIS
		meke weboserver dekak tinawa 
			1.external IIS like apache
			2.internal kestrel can choose
	startap.cs eke apita middleware eka choose karanna puluwan like app.UseRouting()
---------------------------------------------------------
MIDDLEWARE IN ASP.NET
	*request eka server ekata enakota itapasse access karanawa .netcore framework eka 
	 ita passe request eka context object ekakata dagannawa.ita passe middleware eka haraha 
	 yanawa middleware eka response karanam eka context eta attach karagena pass karanawa pipeline
	 eka haraha server ekata eken browser ekata

	*order eka wadagath first to last 
		auth middleware eka gaththama authentication eka harinam thama elaga middleware
		ekata yanne
-------------------------------------------------------------
DEPENDANCY INJECTION
	*mekedi wenne email,database,log tibba kiyamu pages thunak me thunama use karanawa 
	 DI use karanawanam function thunama eka container ekakata dagannawa(like bag ekakata) 
	 ita passe eken aran directly use karanawa.DI naththam karanna wenne function 3ne object 
	 hadala eka use karanna.
---------------------------------------------------------------
	*run karanakota auto refresh wenna nuget package ekak tinawa
		