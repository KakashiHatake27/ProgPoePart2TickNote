   M S B A M L   `   `   `  ????O  KProgPoeTickNotePart2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ProgPoeTickNotePart2ProgPoeTickNotePart2  5   	        ProgPoeTickNotePart2.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ProgPoeTickNotePart2     5   	     ? Title$  Login??5   	   $	??580??5	   	   $	??900??5
   	    ? WindowStyle$
 None=?5   	    ? 
ResizeMode$ NoResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	   .??5      ? ??5   
   ?? 5      -   5        _img_bg?? ?? ImageSource$ Assets/lockScreenBg.png??5       j? Stretch$
 Fill=?5      .+?5   
   ?? -   5        $??
brdEtikett??5      }?.  ?? CornerRadius$ 50??5      $??0 20 0 0q?5      ???#908D8D$	??800??5         borderTransparent#??[  5      $	??440??5      ._?5      ?? 
 ?? Top$ 0??6    ?? Left$ 0??5      
??????   canvasTransparent#??[ 5      5       5!      ?? 5#   
   -   5        $
??line??5#      
???   ?$??1??5%      		 ?? X1$		 450??5&      	
 ?? X2$	
 450??5'      	 ?? Y1$	 100??5(      	 ?? Y2$	 470??5)      ?? 5+   
   -   5         ??Name$ lblUsername??5+      $??100 120 0 0q?5,      $??20(?5-      $??USERNAME??5.      ?? 50   
   -   5         ??Name$ 
tbUsername??50      $??100 160 0 0q?51      $	??Top=?52      $
??Left=?53      $??30??54      $	??280??55      $??20(?56      ?? 59   
   -   5        $ lblPassword??59      $??100 230 0 0q?5:      $??20(?5;      $??PASSWORD??5<      ?? 5>   
   -   5        $ 
tbPassword??5>      $??100 270 0 0q?5?      $	??Top=?5@      $
??Left=?5A      $??30??5B      $	??280??5C      $??20(?5D      ?? 5I   
   -   5         ??Name$ btnLogin??5I      $??Bottom=?5K      $
??Left=?5L      $??140 0 0 140q?5M      $??16(?5N      $	??200??5O        blackRounded#??[ 5P      
???????
???   ?$??LOG IN??5S      ?? 5V   
   -	   5        $ 	btnSignUp??5V      $??Bottom=?5X      $
??Left=?5Y      $??
140 0 0 80q?5Z      $??16(?5[      $	??200??5\      #??[ 5]      
???????
???   ?$??CREATE ACCOUNT??5`      ?? 5d   
   $??0 130 180 0q?6   $??Right=?5e      $??32(?5f      $??DemiBold"?5g      $??LOGIN TO??5h      ?? 5j   
   $	??400??6   $??Right=?5k      $??0 0 60 0q?5l      $??Assets/logo.png??5m      5p      5q      