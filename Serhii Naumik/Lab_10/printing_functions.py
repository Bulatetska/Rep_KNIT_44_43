def print_models(unprinted_designs, completed_models):
    """
    Імітує друк 3D-моделей, доки список не стане порожнім.
    Кожна модель після друку переміщується у completed_models.
    """
    while unprinted_designs:
        current_design = unprinted_designs.pop()
        # Імітація друку моделі на 3D-принтері.
        print("Printing model: " + current_design)
        completed_models.append(current_design)

def show_completed_models(completed_models):
    """Виводить інформацію про усі надруковані моделі."""
    print("\nThe following models have been printed:")
    for completed_model in completed_models:
        print(completed_model)