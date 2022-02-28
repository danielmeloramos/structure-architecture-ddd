namespace Product.Infra.Exceptions
{
    /// <summary>
    /// Representa os códigos padronizados que serão enviados para o cliente
    /// como resposta, no ExceptionPayload.
    /// </summary>
    public enum ErrorCodes
    {
        /// <summary>
        /// Requisição inválida: a requisição está com uma sintaxe inválida.
        /// </summary>
        BadRequest = 400,

        /// <summary>
        /// Unauthorized: Não autorizado, a diferença para 403 é que o usuário não está autenticado.
        /// </summary>
        Unauthorized = 401,

        /// <summary>
        /// Ação proibida. O server entendeu o pedido, mas não pode executá-lo (está autenticado mas não tem permissão)
        /// </summary>
        Forbidden = 403,

        /// <summary>
        ///  Não encontrado
        /// </summary>
        NotFound = 404,

        /// <summary>
        /// HttpStatus Conflict: Já existente
        /// </summary>
        AlreadyExists = 409,

        /// <summary>
        /// equivale ao httpStatus 405 not allowed
        /// </summary>
        NotAllowed = 405,

        /// <summary>
        /// Objeto inválido equivale ao httpStaus 422 Unprocessable Entity
        /// </summary>
        InvalidObject = 422,

        /// <summary>
        /// Exceção não tratada.(Internal Server error)
        /// </summary>
        Unhandled = 500,

        /// <summary>
        /// Serviço não disponível
        /// </summary>
        ServiceUnavailable = 503
    }
}