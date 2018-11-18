#include <iostream>
#include <string>
#include <vector>

class Pirate
{
public:
    Pirate(std::string name, bool hasWoodenLeg, int gold) {
        _name = name;
        _hasWoodenLeg = hasWoodenLeg;
        _gold = gold;
    }

private:
    std::string _name;
    bool _hasWoodenLeg;
    int _gold;
};

int main()
{
    std::vector<Pirate> pirates;

    // Given this vector...

    pirates.push_back(Pirate("Olaf", false, 12));
    pirates.push_back(Pirate("Uwe", true, 9));
    pirates.push_back(Pirate("Jack", true, 16));
    pirates.push_back(Pirate("Morgan", false, 17));
    pirates.push_back(Pirate("Hook", true, 20));

    // Write a function that takes any vector that contains pirates as in the example,
    // And returns a list of names containing the pirates that
    // - have wooden leg and
    // - have more than 15 gold

    return 0;
}
