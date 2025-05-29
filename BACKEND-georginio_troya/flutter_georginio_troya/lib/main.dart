import 'package:flutter/material.dart';
import 'package:buttons_tabbar/buttons_tabbar.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Demo Buttons TabBar',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: const TabBarExample(),
    );
  }
}

class TabBarExample extends StatelessWidget {
  const TabBarExample({super.key});

  @override
  Widget build(BuildContext context) {
    return DefaultTabController(
      length: 3,
      child: Scaffold(
        appBar: AppBar(
          title: const Text("Botones TabBar Demo"),
        ),
        body: Column(
          children: <Widget>[
            ButtonsTabBar(
              backgroundColor: Colors.blue,
              unselectedBackgroundColor: Colors.grey[300],
              unselectedLabelStyle: const TextStyle(color: Colors.black),
              labelStyle: const TextStyle(
                color: Colors.white,
                fontWeight: FontWeight.bold,
              ),
              tabs: const [
                Tab(icon: Icon(Icons.directions_car), text: "Carros"),
                Tab(icon: Icon(Icons.directions_transit), text: "Transporte"),
                Tab(icon: Icon(Icons.directions_bike), text: "Bicicletas"),
              ],
            ),
            const Expanded(
              child: TabBarView(
                children: <Widget>[
                  Center(child: Text("Contenido Carros")),
                  Center(child: Text("Contenido Transporte")),
                  Center(child: Text("Contenido Bicicletas")),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
