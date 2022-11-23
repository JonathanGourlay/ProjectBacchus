import React, { useState } from "react";
import { InfoCarousel } from "./InfoCarousel";
import { MealCard } from "./MealCard";
export const TodaysPlan: React.FC = () => {
    const meals = ["Breakfast", "Lunch", "Dinner", "Snack"]

    return (
        <>
            <div className="overflow-x-auto">
                {/* Put this part before </body> tag */}
                <input type="checkbox" id="my-modal-4" className="modal-toggle" />
                <label htmlFor="my-modal-4" className="modal cursor-pointer">
                    <label className="modal-box relative" htmlFor="">
                        <h3 className="text-lg font-bold">Welcome to Recipes</h3>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                    </label>
                </label>
                <div className="carousel w-200 p-5 space-x-24">
                    {meals.map((meal, i) => {
                        return (
                            <div  >
                                <MealCard title={meal} nutrients={undefined} labels={[]} ingredientLines={[]} calories={420} cusine={[]} image={""} shareAs={4}></MealCard>
                            </div>
                        )
                    })}
                </div>
            </div >
        </>
    );
};
