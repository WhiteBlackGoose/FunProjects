#include <AngouriMath.h>
#include <iostream>


int main()
{
    AngouriMath::Entity expr("x + 2 sin(x) + 2y");
    std::cout << expr;
    // auto newExpr = expr.Differentiate("x");
    // for (auto ent : newExpr.Nodes())
    //     std::cout << ent << "\n";
    /*
    std::cout << "\n\n";
    auto ex = AngouriMath::Entity("x + y");
    for (auto ent : ex.Vars())
        std::cout << ent << "\n";
        
    auto expr = AngouriMath::Entity("5 / 30");
    auto sim = expr.Simplify();
    auto rat = sim.AsRational();
    */
    return 0;
}