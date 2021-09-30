using System;

public class Building
{

	private int _etageBatiment;
	private double _hauteurBatiment;

	public Building (int etage) : this (etage, etage*3)
	{ }

	public Building(int etage, double hauteur)
	{
		_etageBatiment = etage;
		_hauteurBatiment = hauteur;
	}

	public double GetFloorMaxSize ()
    {
		return _hauteurBatiment / _etageBatiment;
    }

	public int GetFloorCount()
    {
		return _etageBatiment;
    }

	public double GetSize()
	{
		return _hauteurBatiment;
	}

}
