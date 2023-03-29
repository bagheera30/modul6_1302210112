// See https://aka.ms/new-console-template for more information
using modul6_1302210112;

sayaTubeUser username = new sayaTubeUser("rizki");
sayaTubeVideo v = new sayaTubeVideo("review film utramen oleh "+username);
username.addvideo(v);
sayaTubeVideo v2 = new sayaTubeVideo("review film captain amarika oleh " + username);
username.addvideo(v2);
sayaTubeVideo v3 = new sayaTubeVideo("review film cek toko sebelah oleh " + username);
username.addvideo(v3);
sayaTubeVideo v4 = new sayaTubeVideo("review film avenger  oleh " + username);
username.addvideo(v4);
sayaTubeVideo v5 = new sayaTubeVideo("review film ninja hatory oleh " + username);
username.addvideo(v5);
sayaTubeVideo v6 = new sayaTubeVideo("review film superman oleh " + username);
username.addvideo(v6);
sayaTubeVideo v7 = new sayaTubeVideo("review film ironman ole " + username);
username.addvideo(v7);
sayaTubeVideo v8 = new sayaTubeVideo("review film hulk oleh " + username);
username.addvideo(v8);
sayaTubeVideo v9 = new sayaTubeVideo("review film doraemon oleh " + username);
username.addvideo(v9);
sayaTubeVideo v10 = new sayaTubeVideo("review film sincan ole " + username);
username.addvideo(v10);
username.playallvideo();

